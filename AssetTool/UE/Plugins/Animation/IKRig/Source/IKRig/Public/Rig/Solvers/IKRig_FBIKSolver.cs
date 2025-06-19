namespace AssetTool
{
    [JsonAsset("IKRig_FBIKEffector")]
    public class UIKRig_FBIKEffector : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_FBIKBoneSettings")]
    public class UIKRig_FBIKBoneSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRigFBIKSolver")]
    public class UIKRigFBIKSolver : UIKRigSolver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}