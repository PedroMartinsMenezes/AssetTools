namespace AssetTool
{
    [JsonAsset("LakeGenerator")]
    public class UDEPRECATED_LakeGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyLake")]
    public class AWaterBodyLake : AWaterBody
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}