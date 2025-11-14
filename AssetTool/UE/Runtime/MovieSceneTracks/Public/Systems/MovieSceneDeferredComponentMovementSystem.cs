namespace AssetTool
{
    [JsonAsset("MovieSceneDeferredComponentMovementSystem")]
    public class UMovieSceneDeferredComponentMovementSystem : UMovieSceneEntitySystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}