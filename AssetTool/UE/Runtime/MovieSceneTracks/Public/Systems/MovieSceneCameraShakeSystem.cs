namespace AssetTool
{
    [JsonAsset("MovieSceneCameraShakeInstantiatorSystem")]
    public class UMovieSceneCameraShakeInstantiatorSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneCameraShakeEvaluatorSystem")]
    public class UMovieSceneCameraShakeEvaluatorSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}