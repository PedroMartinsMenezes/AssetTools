namespace AssetTool
{
    [JsonAsset("WaterBodyGenerator")]
    public class UDEPRECATED_WaterBodyGenerator : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBody")]
    public class AWaterBody : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}