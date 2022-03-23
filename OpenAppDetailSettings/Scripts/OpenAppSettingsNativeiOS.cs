using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAppSettingsNativeiOS
{
#if UNITY_IPHONE
        [DllImport ("__Internal")]
        public static extern string GetSettingsURL();

        [DllImport ("__Internal")]
        public static extern void OpenSettings();
#endif

}
