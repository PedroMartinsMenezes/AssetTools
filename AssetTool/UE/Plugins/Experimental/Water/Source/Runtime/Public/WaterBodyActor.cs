namespace AssetTool
{
    [JsonAsset("DEPRECATED_WaterBodyGenerator")]
    public class UDEPRECATED_WaterBodyGenerator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBody")]
    public class AWaterBody : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}