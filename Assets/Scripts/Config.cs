using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Siyan
{
    public static class Config
    {
        public static string GameId
        {
            get
            {
#if UNITY_EDITOR
                return "";
#elif UNITY_ANDROID
                return "";
#else // UNITY_IOS
                return "";
#endif
            }
        }

        public static bool IsTestAds
        {
            get
            {
                return true;
            }
        }
    }
}