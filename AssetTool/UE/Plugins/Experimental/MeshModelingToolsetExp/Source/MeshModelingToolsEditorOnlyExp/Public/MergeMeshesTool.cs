namespace AssetTool
{
    [JsonAsset("MergeMeshesToolProperties")]
    public class UMergeMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MergeMeshesTool")]
    public class UMergeMeshesTool : UBaseVoxelTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MergeMeshesToolBuilder")]
    public class UMergeMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}