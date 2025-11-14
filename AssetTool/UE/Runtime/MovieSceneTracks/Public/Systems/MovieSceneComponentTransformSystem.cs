namespace AssetTool
{
    [JsonAsset("MovieSceneComponentTransformSystem")]
    public class UMovieSceneComponentTransformSystem : UMovieScenePropertySystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}