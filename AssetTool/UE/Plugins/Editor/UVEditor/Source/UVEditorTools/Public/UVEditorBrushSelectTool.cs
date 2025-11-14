namespace AssetTool
{
    [JsonAsset("UVEditorBrushSelectToolProperties")]
    public class UUVEditorBrushSelectToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorBrushSelectTool")]
    public class UUVEditorBrushSelectTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}