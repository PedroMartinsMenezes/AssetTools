namespace AssetTool
{
    [JsonAsset("GLTFPipelineSettings")]
    public class UGLTFPipelineSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeGLTFPipeline")]
    public class UInterchangeGLTFPipeline : UInterchangePipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}