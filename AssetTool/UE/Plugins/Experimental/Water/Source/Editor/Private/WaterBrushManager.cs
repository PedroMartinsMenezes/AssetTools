namespace AssetTool
{
    [JsonAsset("WaterBrushManager")]
    public class AWaterBrushManager : AWaterLandscapeBrush
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}