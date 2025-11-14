namespace AssetTool
{
    [JsonAsset("OptimusSkinWeightsAsVertexMaskDataInterface")]
    public class UOptimusSkinWeightsAsVertexMaskDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinWeightsAsVertexMaskDataProvider")]
    public class UOptimusSkinWeightsAsVertexMaskDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}