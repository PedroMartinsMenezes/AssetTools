namespace AssetTool
{
    [JsonAsset("LandscapeStreamingProxy")]
    public class ALandscapeStreamingProxy : ALandscapeProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}