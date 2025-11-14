namespace AssetTool
{
    [JsonAsset("MoviePlayerSettings")]
    public class UMoviePlayerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}