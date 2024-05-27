using UnityEditor;
class Builder
{
    static void PerformBuild ()
    {
        // BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        // buildPlayerOptions.scenes = new[] { "Assets/SampleScene.unity"};
        // BuildPipeline.BuildPlayer(buildPlayerOptions);
        string[] scenes = { "Assets/SampleScene.unity" }; // Adjust with your scenes
        string pathToDeploy = "Build/MyGame.exe"; // Adjust the path and filename

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}