namespace AssetTool
{
    [JsonAsset("MovieSceneDeferredComponentMovementSystem")]
    public class UMovieSceneDeferredComponentMovementSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}