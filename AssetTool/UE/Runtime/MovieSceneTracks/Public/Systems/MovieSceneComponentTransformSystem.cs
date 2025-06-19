namespace AssetTool
{
    [JsonAsset("MovieSceneComponentTransformSystem")]
    public class UMovieSceneComponentTransformSystem : UMovieScenePropertySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}