namespace AssetTool
{
    [JsonAsset("InterchangeBlueprintPipelineBaseFactory")]
    public class UInterchangeBlueprintPipelineBaseFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeEditorBlueprintPipelineBaseFactory")]
    public class UInterchangeEditorBlueprintPipelineBaseFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePipelineBaseFactory")]
    public class UInterchangePipelineBaseFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePythonPipelineAssetFactory")]
    public class UInterchangePythonPipelineAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}