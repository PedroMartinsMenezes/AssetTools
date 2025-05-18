namespace AssetTool
{
    [JsonAsset("MovieGraphProjectSettings")]
    public class UMovieGraphProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}