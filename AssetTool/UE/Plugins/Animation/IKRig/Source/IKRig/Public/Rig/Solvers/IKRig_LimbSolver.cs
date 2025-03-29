namespace AssetTool
{
    [JsonAsset("IKRig_LimbEffector")]
    public class UIKRig_LimbEffector : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_LimbSolver")]
    public class UIKRig_LimbSolver : UIKRigSolver
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}