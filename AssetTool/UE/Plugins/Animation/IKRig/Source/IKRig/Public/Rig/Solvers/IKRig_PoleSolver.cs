namespace AssetTool
{
    [JsonAsset("IKRig_PoleSolverEffector")]
    public class UIKRig_PoleSolverEffector : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_PoleSolver")]
    public class UIKRig_PoleSolver : UIKRigSolver
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}