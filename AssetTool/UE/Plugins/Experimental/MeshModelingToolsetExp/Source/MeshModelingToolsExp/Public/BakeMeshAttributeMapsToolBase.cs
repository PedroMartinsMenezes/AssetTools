namespace AssetTool
{
    [JsonAsset("BakeMeshAttributeMapsResultToolProperties")]
    public class UBakeMeshAttributeMapsResultToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeMapsToolBase")]
    public class UBakeMeshAttributeMapsToolBase : UBakeMeshAttributeTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}