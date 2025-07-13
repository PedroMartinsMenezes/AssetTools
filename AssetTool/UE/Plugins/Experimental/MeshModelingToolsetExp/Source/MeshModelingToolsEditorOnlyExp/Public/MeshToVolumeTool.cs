namespace AssetTool
{
    [JsonAsset("MeshToVolumeToolBuilder")]
    public class UMeshToVolumeToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshToVolumeToolProperties")]
    public class UMeshToVolumeToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshToVolumeTool")]
    public class UMeshToVolumeTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}