namespace AssetTool
{
    [JsonAsset("MeshElementsVisualizerProperties")]
    public class UMeshElementsVisualizerProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshElementsVisualizer")]
    public class UMeshElementsVisualizer : UPreviewGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}