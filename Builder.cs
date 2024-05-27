using UnityEditor;
class Builder
{
    static void PerformBuild ()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scene1.unity", "Assets/Scene2.unity" };
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}