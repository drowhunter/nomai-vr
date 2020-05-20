﻿using UnityEngine;
using UnityEngine.XR;
using Valve.VR;

namespace NomaiVR
{
    public class HandsController : NomaiVRModule<HandsController.Behaviour, NomaiVRModule.EmptyPatch>
    {
        protected override bool isPersistent => false;
        protected override OWScene[] scenes => PlayableScenes;

        public class Behaviour : MonoBehaviour
        {
            public static Transform RightHand;
            public static Transform LeftHand;
            Transform _wrapper;

            private void Start()
            {
                _wrapper = new GameObject().transform;

                var right = new GameObject().AddComponent<Hand>();
                right.pose = SteamVR_Actions.default_RightHand;
                right.transform.parent = _wrapper;
                right.transform.localPosition = new Vector3(0.03f, 0.05f, -0.2f);
                right.transform.localRotation = Quaternion.Euler(313f, 10f, 295f);
                right.handPrefab = AssetLoader.HandPrefab;
                right.glovePrefab = AssetLoader.GlovePrefab;
                RightHand = right.transform;

                var left = new GameObject().AddComponent<Hand>();
                left.pose = SteamVR_Actions.default_LeftHand;
                left.transform.parent = _wrapper;
                left.transform.localPosition = new Vector3(-0.03f, 0.05f, -0.2f);
                left.transform.localRotation = Quaternion.Euler(313f, 350f, 65f);
                left.isLeft = true;
                left.handPrefab = AssetLoader.HandPrefab;
                left.glovePrefab = AssetLoader.GlovePrefab;
                LeftHand = left.transform;

                _wrapper.parent = Camera.main.transform.parent;
                _wrapper.localRotation = Quaternion.identity;
                _wrapper.localPosition = Camera.main.transform.localPosition;

                HideBody();
            }

            void HideBody()
            {
                var bodyModels = Locator.GetPlayerBody().transform.Find("Traveller_HEA_Player_v2");

                // Legs, torso and head are kept visible to the probe camera,
                // so we can still take some selfies when we're feelinf cute.
                var renderers = bodyModels.GetComponentsInChildren<SkinnedMeshRenderer>(true);
                foreach (var renderer in renderers)
                {
                    if (renderer.name.Contains("ShadowCaster") || renderer.name.Contains("Head") || renderer.name.Contains("Helmet"))
                    {
                        continue;
                    }

                    // Make the player body shadows visible to the player camera.
                    var shadowCaster = Instantiate(renderer);
                    shadowCaster.transform.parent = renderer.transform;
                    shadowCaster.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                    // Make this body mesh only visible to the probe launcher camera.
                    renderer.gameObject.layer = LayerMask.NameToLayer("VisibleToProbe");
                }

                // Arms are always hidden, since we have our own motion-controlled hands.
                var withoutSuit = bodyModels.Find("player_mesh_noSuit:Traveller_HEA_Player");
                withoutSuit.Find("player_mesh_noSuit:Player_LeftArm").gameObject.SetActive(false);
                withoutSuit.Find("player_mesh_noSuit:Player_RightArm").gameObject.SetActive(false);
                var withSuit = bodyModels.Find("Traveller_Mesh_v01:Traveller_Geo");
                withSuit.Find("Traveller_Mesh_v01:PlayerSuit_LeftArm").gameObject.SetActive(false);
                withSuit.Find("Traveller_Mesh_v01:PlayerSuit_RightArm").gameObject.SetActive(false);
            }

            void Update()
            {
                if (_wrapper && Camera.main)
                {
                    _wrapper.localPosition = Camera.main.transform.localPosition - InputTracking.GetLocalPosition(XRNode.CenterEye);
                }
            }
        }
    }
}