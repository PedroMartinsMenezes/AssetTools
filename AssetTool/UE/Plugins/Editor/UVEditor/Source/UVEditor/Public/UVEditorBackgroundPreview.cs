namespace AssetTool
{
    [JsonAsset("UVEditorBackgroundPreviewProperties")]
    public class UUVEditorBackgroundPreviewProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorBackgroundPreview")]
    public class UUVEditorBackgroundPreview : UPreviewGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}