namespace AssetTool
{
    [JsonAsset("LandmassManagerBase")]
    public class ALandmassManagerBase : ALandscapeBlueprintBrushBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}