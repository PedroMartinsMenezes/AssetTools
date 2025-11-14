namespace AssetTool
{
    [JsonAsset("CustomMeshGenerator")]
    public class UDEPRECATED_CustomMeshGenerator : UDEPRECATED_WaterBodyGenerator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyCustom")]
    public class AWaterBodyCustom : AWaterBody
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}