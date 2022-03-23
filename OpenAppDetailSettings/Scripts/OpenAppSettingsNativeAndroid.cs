using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAppSettingsNativeAndroid
{
    private static AndroidJavaObject _openAppSettingUtilities;


#if UNITY_ANDROID
    public static void OpenSettings()
    {
        AndroidJavaClass playerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivityObject = playerClass.GetStatic<AndroidJavaObject>("currentActivity");
        if (_openAppSettingUtilities == null)
        {
            _openAppSettingUtilities = new AndroidJavaObject("com.imosys.openappdetailsettings.OpenAppSettingUtilities");
        }
        _openAppSettingUtilities.CallStatic("startInstalledAppDetailsActivity", currentActivityObject);
    }
#endif
}
