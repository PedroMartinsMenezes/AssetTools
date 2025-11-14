namespace AssetTool
{
    [JsonAsset("LandmassErosionBrushBase")]
    public class ALandmassErosionBrushBase : ALandscapeBlueprintBrushBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}