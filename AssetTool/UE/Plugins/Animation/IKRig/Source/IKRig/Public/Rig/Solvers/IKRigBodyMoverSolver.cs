namespace AssetTool
{
    [JsonAsset("IKRigBodyMoverController")]
    public class UIKRigBodyMoverController : UIKRigSolverControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_BodyMoverEffector")]
    public class UIKRig_BodyMoverEffector : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_BodyMover")]
    public class UIKRig_BodyMover : UIKRigSolver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}