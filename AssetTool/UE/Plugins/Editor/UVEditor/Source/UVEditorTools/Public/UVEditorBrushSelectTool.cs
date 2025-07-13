namespace AssetTool
{
    [JsonAsset("UVEditorBrushSelectToolProperties")]
    public class UUVEditorBrushSelectToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorBrushSelectTool")]
    public class UUVEditorBrushSelectTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}