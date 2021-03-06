﻿namespace NomaiVR
{
    public static class InputHelper
    {
        public static bool IsUIInteractionMode(bool includeDialogue = false)
        {
            return OWInput.IsInputMode(
                InputMode.Menu |
                InputMode.KeyboardInput |
                (includeDialogue ? InputMode.Dialogue : 0)
            );
        }
    }
}
