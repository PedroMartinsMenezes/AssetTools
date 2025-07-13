namespace AssetTool
{
    [JsonAsset("WaterLandscapeBrush")]
    public class AWaterLandscapeBrush : ALandscapeBlueprintBrush
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}