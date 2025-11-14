namespace AssetTool
{
    [JsonAsset("IKRigPoleSolverController")]
    public class UIKRigPoleSolverController : UIKRigSolverControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_PoleSolverEffector")]
    public class UIKRig_PoleSolverEffector : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_PoleSolver")]
    public class UIKRig_PoleSolver : UIKRigSolver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}