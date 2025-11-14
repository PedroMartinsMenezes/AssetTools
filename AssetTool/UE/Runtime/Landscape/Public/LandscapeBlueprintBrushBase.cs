namespace AssetTool
{
    [JsonAsset("LandscapeBlueprintBrushBase")]
    public class ALandscapeBlueprintBrushBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}