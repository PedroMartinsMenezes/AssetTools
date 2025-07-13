namespace AssetTool
{
    [JsonAsset("VoxelBlendMeshesToolProperties")]
    public class UVoxelBlendMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelBlendMeshesTool")]
    public class UVoxelBlendMeshesTool : UBaseVoxelTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelBlendMeshesToolBuilder")]
    public class UVoxelBlendMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}