namespace AssetTool
{
    [JsonAsset("CompositingMediaInput")]
    public class UCompositingMediaInput : UCompositingElementInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaTextureCompositingInput")]
    public class UMediaTextureCompositingInput : UCompositingMediaInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingInputInterfaceProxy")]
    public class UCompositingInputInterfaceProxy : UCompositingElementInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}