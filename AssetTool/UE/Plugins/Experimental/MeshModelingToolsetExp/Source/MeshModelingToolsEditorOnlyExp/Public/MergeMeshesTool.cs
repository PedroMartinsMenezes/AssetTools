namespace AssetTool
{
    [JsonAsset("MergeMeshesToolProperties")]
    public class UMergeMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MergeMeshesTool")]
    public class UMergeMeshesTool : UBaseVoxelTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MergeMeshesToolBuilder")]
    public class UMergeMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}