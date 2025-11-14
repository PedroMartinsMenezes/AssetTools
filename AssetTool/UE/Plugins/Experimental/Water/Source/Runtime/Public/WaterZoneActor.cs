namespace AssetTool
{
    [JsonAsset("WaterZone")]
    public class AWaterZone : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}