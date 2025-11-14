namespace AssetTool
{
    [JsonAsset("MovieGraphProjectSettings")]
    public class UMovieGraphProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}