namespace AssetTool
{
    [JsonAsset("OceanGenerator")]
    public class UDEPRECATED_OceanGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyOcean")]
    public class AWaterBodyOcean : AWaterBody
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}