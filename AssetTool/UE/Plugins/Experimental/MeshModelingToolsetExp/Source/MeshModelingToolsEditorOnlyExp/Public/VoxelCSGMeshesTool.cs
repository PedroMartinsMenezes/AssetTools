namespace AssetTool
{
    [JsonAsset("VoxelCSGMeshesToolProperties")]
    public class UVoxelCSGMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelCSGMeshesTool")]
    public class UVoxelCSGMeshesTool : UBaseVoxelTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelCSGMeshesToolBuilder")]
    public class UVoxelCSGMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}