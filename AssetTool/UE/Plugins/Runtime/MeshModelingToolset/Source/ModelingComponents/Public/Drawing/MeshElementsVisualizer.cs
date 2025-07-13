namespace AssetTool
{
    [JsonAsset("MeshElementsVisualizerProperties")]
    public class UMeshElementsVisualizerProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshElementsVisualizer")]
    public class UMeshElementsVisualizer : UPreviewGeometry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}