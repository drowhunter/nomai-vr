// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_default_X;
        
        private static SteamVR_Action_Boolean p_default_A;
        
        private static SteamVR_Action_Boolean p_default_Y;
        
        private static SteamVR_Action_Boolean p_default_B;
        
        private static SteamVR_Action_Boolean p_default_RB;
        
        private static SteamVR_Action_Boolean p_default_LB;
        
        private static SteamVR_Action_Single p_default_RT;
        
        private static SteamVR_Action_Single p_default_LT;
        
        private static SteamVR_Action_Vector2 p_default_RStick;
        
        private static SteamVR_Action_Vector2 p_default_LStick;
        
        private static SteamVR_Action_Boolean p_default_Start;
        
        private static SteamVR_Action_Boolean p_default_Select;
        
        private static SteamVR_Action_Boolean p_default_DUp;
        
        private static SteamVR_Action_Boolean p_default_DDown;
        
        private static SteamVR_Action_Boolean p_default_DLeft;
        
        private static SteamVR_Action_Boolean p_default_DRight;
        
        private static SteamVR_Action_Pose p_default_RightPose;
        
        private static SteamVR_Action_Pose p_default_LeftPose;
        
        private static SteamVR_Action_Vibration p_default_Haptic;
        
        public static SteamVR_Action_Boolean default_X
        {
            get
            {
                return SteamVR_Actions.p_default_X.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_A
        {
            get
            {
                return SteamVR_Actions.p_default_A.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Y
        {
            get
            {
                return SteamVR_Actions.p_default_Y.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_B
        {
            get
            {
                return SteamVR_Actions.p_default_B.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_RB
        {
            get
            {
                return SteamVR_Actions.p_default_RB.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_LB
        {
            get
            {
                return SteamVR_Actions.p_default_LB.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Single default_RT
        {
            get
            {
                return SteamVR_Actions.p_default_RT.GetCopy <SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Single default_LT
        {
            get
            {
                return SteamVR_Actions.p_default_LT.GetCopy <SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Vector2 default_RStick
        {
            get
            {
                return SteamVR_Actions.p_default_RStick.GetCopy <SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Vector2 default_LStick
        {
            get
            {
                return SteamVR_Actions.p_default_LStick.GetCopy <SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Start
        {
            get
            {
                return SteamVR_Actions.p_default_Start.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Select
        {
            get
            {
                return SteamVR_Actions.p_default_Select.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_DUp
        {
            get
            {
                return SteamVR_Actions.p_default_DUp.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_DDown
        {
            get
            {
                return SteamVR_Actions.p_default_DDown.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_DLeft
        {
            get
            {
                return SteamVR_Actions.p_default_DLeft.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_DRight
        {
            get
            {
                return SteamVR_Actions.p_default_DRight.GetCopy <SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose default_RightPose
        {
            get
            {
                return SteamVR_Actions.p_default_RightPose.GetCopy <SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Pose default_LeftPose
        {
            get
            {
                return SteamVR_Actions.p_default_LeftPose.GetCopy <SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Vibration default_Haptic
        {
            get
            {
                return SteamVR_Actions.p_default_Haptic.GetCopy <SteamVR_Action_Vibration>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[]
            {
                    SteamVR_Actions.default_X,
                    SteamVR_Actions.default_A,
                    SteamVR_Actions.default_Y,
                    SteamVR_Actions.default_B,
                    SteamVR_Actions.default_RB,
                    SteamVR_Actions.default_LB,
                    SteamVR_Actions.default_RT,
                    SteamVR_Actions.default_LT,
                    SteamVR_Actions.default_RStick,
                    SteamVR_Actions.default_LStick,
                    SteamVR_Actions.default_Start,
                    SteamVR_Actions.default_Select,
                    SteamVR_Actions.default_DUp,
                    SteamVR_Actions.default_DDown,
                    SteamVR_Actions.default_DLeft,
                    SteamVR_Actions.default_DRight,
                    SteamVR_Actions.default_RightPose,
                    SteamVR_Actions.default_LeftPose,
                    SteamVR_Actions.default_Haptic};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[]
            {
                    SteamVR_Actions.default_X,
                    SteamVR_Actions.default_A,
                    SteamVR_Actions.default_Y,
                    SteamVR_Actions.default_B,
                    SteamVR_Actions.default_RB,
                    SteamVR_Actions.default_LB,
                    SteamVR_Actions.default_RT,
                    SteamVR_Actions.default_LT,
                    SteamVR_Actions.default_RStick,
                    SteamVR_Actions.default_LStick,
                    SteamVR_Actions.default_Start,
                    SteamVR_Actions.default_Select,
                    SteamVR_Actions.default_DUp,
                    SteamVR_Actions.default_DDown,
                    SteamVR_Actions.default_DLeft,
                    SteamVR_Actions.default_DRight,
                    SteamVR_Actions.default_RightPose,
                    SteamVR_Actions.default_LeftPose};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[]
            {
                    SteamVR_Actions.default_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[]
            {
                    SteamVR_Actions.default_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[]
            {
                    SteamVR_Actions.default_RightPose,
                    SteamVR_Actions.default_LeftPose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[]
            {
                    SteamVR_Actions.default_X,
                    SteamVR_Actions.default_A,
                    SteamVR_Actions.default_Y,
                    SteamVR_Actions.default_B,
                    SteamVR_Actions.default_RB,
                    SteamVR_Actions.default_LB,
                    SteamVR_Actions.default_Start,
                    SteamVR_Actions.default_Select,
                    SteamVR_Actions.default_DUp,
                    SteamVR_Actions.default_DDown,
                    SteamVR_Actions.default_DLeft,
                    SteamVR_Actions.default_DRight};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[]
            {
                    SteamVR_Actions.default_RT,
                    SteamVR_Actions.default_LT};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[]
            {
                    SteamVR_Actions.default_RStick,
                    SteamVR_Actions.default_LStick};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[0];
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[]
            {
                    SteamVR_Actions.default_X,
                    SteamVR_Actions.default_A,
                    SteamVR_Actions.default_Y,
                    SteamVR_Actions.default_B,
                    SteamVR_Actions.default_RB,
                    SteamVR_Actions.default_LB,
                    SteamVR_Actions.default_RT,
                    SteamVR_Actions.default_LT,
                    SteamVR_Actions.default_RStick,
                    SteamVR_Actions.default_LStick,
                    SteamVR_Actions.default_Start,
                    SteamVR_Actions.default_Select,
                    SteamVR_Actions.default_DUp,
                    SteamVR_Actions.default_DDown,
                    SteamVR_Actions.default_DLeft,
                    SteamVR_Actions.default_DRight};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_default_X = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/X")));
            SteamVR_Actions.p_default_A = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/A")));
            SteamVR_Actions.p_default_Y = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/Y")));
            SteamVR_Actions.p_default_B = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/B")));
            SteamVR_Actions.p_default_RB = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/RB")));
            SteamVR_Actions.p_default_LB = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/LB")));
            SteamVR_Actions.p_default_RT = ((SteamVR_Action_Single)(SteamVR_Action.Create <SteamVR_Action_Single>("/actions/default/in/RT")));
            SteamVR_Actions.p_default_LT = ((SteamVR_Action_Single)(SteamVR_Action.Create <SteamVR_Action_Single>("/actions/default/in/LT")));
            SteamVR_Actions.p_default_RStick = ((SteamVR_Action_Vector2)(SteamVR_Action.Create <SteamVR_Action_Vector2>("/actions/default/in/RStick")));
            SteamVR_Actions.p_default_LStick = ((SteamVR_Action_Vector2)(SteamVR_Action.Create <SteamVR_Action_Vector2>("/actions/default/in/LStick")));
            SteamVR_Actions.p_default_Start = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/Start")));
            SteamVR_Actions.p_default_Select = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/Select")));
            SteamVR_Actions.p_default_DUp = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/DUp")));
            SteamVR_Actions.p_default_DDown = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/DDown")));
            SteamVR_Actions.p_default_DLeft = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/DLeft")));
            SteamVR_Actions.p_default_DRight = ((SteamVR_Action_Boolean)(SteamVR_Action.Create <SteamVR_Action_Boolean>("/actions/default/in/DRight")));
            SteamVR_Actions.p_default_RightPose = ((SteamVR_Action_Pose)(SteamVR_Action.Create <SteamVR_Action_Pose>("/actions/default/in/RightPose")));
            SteamVR_Actions.p_default_LeftPose = ((SteamVR_Action_Pose)(SteamVR_Action.Create <SteamVR_Action_Pose>("/actions/default/in/LeftPose")));
            SteamVR_Actions.p_default_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create <SteamVR_Action_Vibration>("/actions/default/out/Haptic")));
        }
    }
}
