namespace AssetTool
{
    [JsonAsset("IKRigLimbSolverController")]
    public class UIKRigLimbSolverController : UIKRigSolverControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_LimbEffector")]
    public class UIKRig_LimbEffector : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_LimbSolver")]
    public class UIKRig_LimbSolver : UIKRigSolver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}