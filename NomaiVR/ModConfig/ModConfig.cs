﻿using UnityEngine;
using UnityEngine.XR;

namespace NomaiVR
{
    public class ModConfig
    {
        public bool showMirrorView = true;
        public bool debugMode = true;
        public bool preventCursorLock = true;
        public bool showHelmet = true;
        public bool hideHudInConversations = false;
        public int overrideRefreshRate = 0;
        public float vibrationStrength = 1;
        public bool enableGesturePrompts = true;
        public bool controllerOrientedMovement = false;

        public ModConfig()
        {
            XRSettings.showDeviceView = showMirrorView;

            if (preventCursorLock)
            {
                NomaiVR.Empty<CursorManager>("Update");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
