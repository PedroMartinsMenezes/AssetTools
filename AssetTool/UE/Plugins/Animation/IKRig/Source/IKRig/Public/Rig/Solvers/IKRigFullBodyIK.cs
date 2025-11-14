namespace AssetTool
{
    [JsonAsset("IKRigFBIKController")]
    public class UIKRigFBIKController : UIKRigSolverControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_FBIKEffector")]
    public class UIKRig_FBIKEffector : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_FBIKBoneSettings")]
    public class UIKRig_FBIKBoneSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRigFBIKSolver")]
    public class UIKRigFBIKSolver : UIKRigSolver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}