namespace AssetTool
{
    [JsonAsset("MovieGraphQuickRenderSettings")]
    public class UMovieGraphQuickRenderSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphQuickRenderModeSettings")]
    public class UMovieGraphQuickRenderModeSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}