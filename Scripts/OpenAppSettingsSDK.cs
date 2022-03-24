using AppSettingsSDK;

public class OpenAppSettingsSDK
{
    public static void OpenAppSettingDetailPopup()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        OpenAppSettingsNativeAndroid.OpenSettings();
#endif
#if UNITY_IOS && !UNITY_EDITOR
        OpenAppSettingsNativeiOS.OpenSettings();
#endif
    }
}
