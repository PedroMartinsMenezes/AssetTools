namespace AssetTool
{
    [JsonAsset("CompositingElementPass")]
    public class UCompositingElementPass : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingElementInput")]
    public class UCompositingElementInput : UCompositingElementPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingElementTransform")]
    public class UCompositingElementTransform : UCompositingElementPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingElementOutput")]
    public class UCompositingElementOutput : UCompositingElementPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}