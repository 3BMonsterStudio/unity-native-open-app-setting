# Unity Open App Detail Settings 
## Instal Package via UPM

Add this line to UPM Window for installing this plugins

    https://github.com/3BMonsterStudio/unity-native-open-app-setting.git

## How To Use
Call this function for open detail app setting activity
    public void OpenAppSettingDetailPopup()
    {
    #if UNITY_ANDROID && !UNITY_EDITOR
        OpenAppSettingsNativeAndroid.OpenSettings();
    #endif
    #if UNITY_IOS && !UNITY_EDITOR
        OpenAppSettingsNativeiOS.OpenSettings();
    #endif
    }