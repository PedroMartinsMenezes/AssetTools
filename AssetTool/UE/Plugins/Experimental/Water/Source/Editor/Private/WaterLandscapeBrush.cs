namespace AssetTool
{
    [JsonAsset("WaterLandscapeBrush")]
    public class AWaterLandscapeBrush : ALandscapeBlueprintBrush
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}