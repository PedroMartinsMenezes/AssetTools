namespace AssetTool
{
    [JsonAsset("VoxelSolidifyMeshesToolProperties")]
    public class UVoxelSolidifyMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelSolidifyMeshesTool")]
    public class UVoxelSolidifyMeshesTool : UBaseVoxelTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelSolidifyMeshesToolBuilder")]
    public class UVoxelSolidifyMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}