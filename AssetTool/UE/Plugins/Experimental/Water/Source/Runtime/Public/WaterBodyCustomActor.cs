namespace AssetTool
{
    [JsonAsset("CustomMeshGenerator")]
    public class UDEPRECATED_CustomMeshGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyCustom")]
    public class AWaterBodyCustom : AWaterBody
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}