namespace AssetTool
{
    [JsonAsset("LandscapeHLODBuilder")]
    public class ULandscapeHLODBuilder : UHLODBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}