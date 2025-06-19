namespace AssetTool
{
    [JsonAsset("CompositingMediaInput")]
    public class UCompositingMediaInput : UCompositingElementInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaTextureCompositingInput")]
    public class UMediaTextureCompositingInput : UCompositingMediaInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingInputInterfaceProxy")]
    public class UCompositingInputInterfaceProxy : UCompositingElementInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}