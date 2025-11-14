namespace AssetTool
{
    [JsonAsset("VoxelBlendMeshesToolProperties")]
    public class UVoxelBlendMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelBlendMeshesTool")]
    public class UVoxelBlendMeshesTool : UBaseVoxelTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelBlendMeshesToolBuilder")]
    public class UVoxelBlendMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}