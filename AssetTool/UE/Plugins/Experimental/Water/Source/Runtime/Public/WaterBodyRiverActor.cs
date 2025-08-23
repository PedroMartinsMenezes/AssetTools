namespace AssetTool
{
    [JsonAsset("RiverGenerator")]
    public class UDEPRECATED_RiverGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyRiver")]
    public class AWaterBodyRiver : AWaterBody
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}