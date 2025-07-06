namespace AssetTool
{
    [JsonAsset("RCVirtualPropertyBase")]
    public class URCVirtualPropertyBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RCVirtualPropertyInContainer")]
    public class URCVirtualPropertyInContainer : URCVirtualPropertyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RCVirtualPropertySelfContainer")]
    public class URCVirtualPropertySelfContainer : URCVirtualPropertyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}