namespace AssetTool
{
    [JsonAsset("IKRetargetOpControllerBase")]
    public class UIKRetargetOpControllerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RetargetOpBase")]
    public class URetargetOpBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RetargetOpStack")]
    public class URetargetOpStack : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}