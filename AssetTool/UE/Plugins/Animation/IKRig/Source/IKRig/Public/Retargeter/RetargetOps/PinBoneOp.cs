namespace AssetTool
{
    [JsonAsset("IKRetargetPinBoneController")]
    public class UIKRetargetPinBoneController : UIKRetargetOpControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PinBoneOp")]
    public class UPinBoneOp : URetargetOpBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}