namespace AssetTool
{
    [JsonAsset("BakeMeshAttributeMapsResultToolProperties")]
    public class UBakeMeshAttributeMapsResultToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BakeMeshAttributeMapsToolBase")]
    public class UBakeMeshAttributeMapsToolBase : UBakeMeshAttributeTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}