namespace AssetTool
{
    [JsonAsset("IKRetargetRootMotionController")]
    public class UIKRetargetRootMotionController : UIKRetargetOpControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RootMotionGeneratorOp")]
    public class URootMotionGeneratorOp : URetargetOpBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}