namespace AssetTool
{
    [JsonAsset("DEPRECATED_LakeGenerator")]
    public class UDEPRECATED_LakeGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyLake")]
    public class AWaterBodyLake : AWaterBody
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}