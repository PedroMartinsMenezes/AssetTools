namespace AssetTool
{
    [JsonAsset("LandscapeStreamingProxy")]
    public class ALandscapeStreamingProxy : ALandscapeProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}