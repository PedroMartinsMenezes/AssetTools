namespace AssetTool
{
    [JsonAsset("LandscapeBlueprintBrushBase")]
    public class ALandscapeBlueprintBrushBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}