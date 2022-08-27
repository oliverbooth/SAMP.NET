using System;

namespace SAMP.Core
{
    internal class Exceptions
    {
        // API
        public static Exception GameModeInitialized = new Exception("The GmaeMode has already been initialized.");
        public static Exception TextDrawDestroyed = new Exception("The TextDraw has been destroyed.");
        public static Exception PlayerNotConnected = new Exception("The player isn't connected.");
        public static Exception PickupMaxLimit = new Exception("The maximum number of pickups has been exceeded.");
    };
};