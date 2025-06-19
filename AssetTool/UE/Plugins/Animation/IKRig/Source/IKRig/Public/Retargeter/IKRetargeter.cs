namespace AssetTool
{
    [JsonAsset("RetargetChainSettings")]
    public class URetargetChainSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RetargetRootSettings")]
    public class URetargetRootSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRetargetGlobalSettings")]
    public class UIKRetargetGlobalSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRetargeter")]
    public class UIKRetargeter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}