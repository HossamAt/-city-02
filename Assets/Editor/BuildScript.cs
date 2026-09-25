using UnityEditor;
using UnityEditor.Build.Reporting;
using System;

public static class BuildScript
{
    public static void BuildAndroid()
    {
        string[] scenes =
        {
            "Assets/City - 02 - Day.unity"
        };

        string outputPath = "build/City02.apk";

        BuildPlayerOptions options = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = outputPath,
            target = BuildTarget.Android,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(options);

        if (report.summary.result != BuildResult.Succeeded)
        {
            throw new Exception(
                "Android build failed: " + report.summary.result
            );
        }

        UnityEngine.Debug.Log(
            "APK created successfully: " + outputPath
        );
    }
}
