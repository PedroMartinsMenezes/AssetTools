namespace AssetTool
{
    [JsonAsset("LandmassErosionBrushBase")]
    public class ALandmassErosionBrushBase : ALandscapeBlueprintBrushBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}