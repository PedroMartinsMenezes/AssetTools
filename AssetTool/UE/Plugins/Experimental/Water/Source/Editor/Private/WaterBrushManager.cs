namespace AssetTool
{
    [JsonAsset("WaterBrushManager")]
    public class AWaterBrushManager : AWaterLandscapeBrush
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}