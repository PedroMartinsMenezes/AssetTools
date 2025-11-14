namespace AssetTool
{
    [JsonAsset("MovieSceneCustomBinding")]
    public class UMovieSceneCustomBinding : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}