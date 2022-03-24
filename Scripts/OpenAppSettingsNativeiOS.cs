using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AppSettingsSDK
{
    public class OpenAppSettingsNativeiOS
    {
#if UNITY_IPHONE
        [DllImport ("__Internal")]
        public static extern string GetSettingsURL();

        [DllImport ("__Internal")]
        public static extern void OpenSettings();
#endif

    }
}

