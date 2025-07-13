namespace AssetTool
{
    [JsonAsset("WaterZone")]
    public class AWaterZone : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}