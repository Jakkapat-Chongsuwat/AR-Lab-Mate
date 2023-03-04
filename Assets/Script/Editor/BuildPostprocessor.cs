using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

public class BuildPostprocessor
{
    [PostProcessBuildAttribute(1)]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        // Increment the build number
        string[] versionParts = PlayerSettings.bundleVersion.Split('.');
        if (versionParts.Length != 3 || !int.TryParse(versionParts[2], out int buildNumber))
        {
            Debug.LogError("BuildPostprocessor failed to update version " + PlayerSettings.bundleVersion);
            return;
        }
        buildNumber++;
        PlayerSettings.bundleVersion = string.Join(".", versionParts[0], versionParts[1], buildNumber);

        // Update CFBundleVersion in project settings
        PlayerSettings.iOS.buildNumber = PlayerSettings.bundleVersion;
        PlayerSettings.macOS.buildNumber = PlayerSettings.bundleVersion;

        // Update Info.plist with the new version number (iOS/Mac only)
#if UNITY_IOS || UNITY_STANDALONE_OSX
        string plistPath = pathToBuiltProject + "/Info.plist";
        PlistDocument plist = new PlistDocument();
        plist.ReadFromString(File.ReadAllText(plistPath));
        plist.root.SetString("CFBundleVersion", PlayerSettings.bundleVersion);
        File.WriteAllText(plistPath, plist.WriteToString());
#endif

        // Update Version.txt with the new version number
        string versionFilePath = Application.dataPath.Replace("/Assets", "") + "/Version.txt";
        string versionNumber = PlayerSettings.bundleVersion;
        using (StreamWriter writer = File.CreateText(versionFilePath))
        {
            writer.WriteLine(versionNumber);
        }

        // Copy Version.txt to project folder
        string projectFolderPath = Application.dataPath.Replace("/Assets", "");
        string destinationPath = Path.Combine(projectFolderPath, "Version.txt");
        File.Copy(versionFilePath, destinationPath, true);
    }
}
