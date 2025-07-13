namespace AssetTool
{
    [JsonAsset("LandmassManagerBase")]
    public class ALandmassManagerBase : ALandscapeBlueprintBrushBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}