using UnityEditor;
class Builder
{
    static void PerformBuild ()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/SampleScene.unity"};
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}