namespace AssetTool
{
    [JsonAsset("UVEditorDistortionVisualizationProperties")]
    public class UUVEditorDistortionVisualizationProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorDistortionVisualization")]
    public class UUVEditorDistortionVisualization : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}