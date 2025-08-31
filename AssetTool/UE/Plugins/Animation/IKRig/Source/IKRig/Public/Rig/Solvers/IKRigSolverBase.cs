namespace AssetTool
{
    [JsonAsset("IKRigSolver")]
    public class UIKRigSolver : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRigSolverControllerBase")]
    public class UIKRigSolverControllerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}