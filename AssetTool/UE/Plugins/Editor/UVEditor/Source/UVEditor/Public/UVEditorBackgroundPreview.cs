namespace AssetTool
{
    [JsonAsset("UVEditorBackgroundPreviewProperties")]
    public class UUVEditorBackgroundPreviewProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorBackgroundPreview")]
    public class UUVEditorBackgroundPreview : UPreviewGeometry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}