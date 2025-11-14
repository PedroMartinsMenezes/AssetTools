namespace AssetTool
{
    [JsonAsset("InterchangeEditorPipelineBase")]
    public class UInterchangeEditorPipelineBase : UInterchangePipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeEditorBlueprintPipelineBase")]
    public class UInterchangeEditorBlueprintPipelineBase : UInterchangeBlueprintPipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}