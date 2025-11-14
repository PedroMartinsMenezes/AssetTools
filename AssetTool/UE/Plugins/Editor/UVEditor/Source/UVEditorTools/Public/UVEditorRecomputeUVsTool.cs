namespace AssetTool
{
    [JsonAsset("UVEditorRecomputeUVsToolBuilder")]
    public class UUVEditorRecomputeUVsToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorRecomputeUVsTool")]
    public class UUVEditorRecomputeUVsTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}