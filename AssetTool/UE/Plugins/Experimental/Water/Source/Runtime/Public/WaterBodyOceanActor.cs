namespace AssetTool
{
    [JsonAsset("DEPRECATED_OceanGenerator")]
    public class UDEPRECATED_OceanGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyOcean")]
    public class AWaterBodyOcean : AWaterBody
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}