namespace AssetTool
{
    [JsonAsset("MovieSceneCopyableBinding")]
    public class UMovieSceneCopyableBinding : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}