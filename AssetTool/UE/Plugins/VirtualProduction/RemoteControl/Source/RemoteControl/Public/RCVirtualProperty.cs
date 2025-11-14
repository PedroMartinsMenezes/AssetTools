namespace AssetTool
{
    [JsonAsset("RCVirtualPropertyBase")]
    public class URCVirtualPropertyBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RCVirtualPropertyInContainer")]
    public class URCVirtualPropertyInContainer : URCVirtualPropertyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RCVirtualPropertySelfContainer")]
    public class URCVirtualPropertySelfContainer : URCVirtualPropertyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}