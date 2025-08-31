namespace AssetTool
{
    [JsonAsset("IKRetargetCurveRemapController")]
    public class UIKRetargetCurveRemapController : UIKRetargetOpControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CurveRemapOp")]
    public class UCurveRemapOp : URetargetOpBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}