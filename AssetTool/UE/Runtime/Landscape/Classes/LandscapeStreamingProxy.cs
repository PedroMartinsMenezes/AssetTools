namespace AssetTool
{
    [JsonAsset("LandscapeStreamingProxy")]
    public class ALandscapeStreamingProxy : ALandscapeProxy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}