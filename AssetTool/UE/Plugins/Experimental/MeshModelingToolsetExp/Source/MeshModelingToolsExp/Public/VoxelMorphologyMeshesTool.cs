namespace AssetTool
{
    [JsonAsset("VoxelMorphologyMeshesToolProperties")]
    public class UVoxelMorphologyMeshesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelMorphologyMeshesTool")]
    public class UVoxelMorphologyMeshesTool : UBaseVoxelTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VoxelMorphologyMeshesToolBuilder")]
    public class UVoxelMorphologyMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}