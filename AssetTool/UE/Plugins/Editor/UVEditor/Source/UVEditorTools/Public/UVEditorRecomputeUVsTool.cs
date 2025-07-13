namespace AssetTool
{
    [JsonAsset("UVEditorRecomputeUVsToolBuilder")]
    public class UUVEditorRecomputeUVsToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorRecomputeUVsTool")]
    public class UUVEditorRecomputeUVsTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}