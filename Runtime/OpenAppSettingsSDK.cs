using AppSettingsSDK;
/// <summary>
/// This class only work in mobile device
/// Remember to check is UNITY_EDITOR when call this function
/// </summary>
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
