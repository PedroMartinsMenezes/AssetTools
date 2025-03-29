namespace AssetTool
{
    [JsonAsset("IKRig_BodyMoverEffector")]
    public class UIKRig_BodyMoverEffector : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_BodyMover")]
    public class UIKRig_BodyMover : UIKRigSolver
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}