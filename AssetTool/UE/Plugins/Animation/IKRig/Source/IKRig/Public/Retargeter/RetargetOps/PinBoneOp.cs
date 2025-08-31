namespace AssetTool
{
    [JsonAsset("IKRetargetPinBoneController")]
    public class UIKRetargetPinBoneController : UIKRetargetOpControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PinBoneOp")]
    public class UPinBoneOp : URetargetOpBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}