namespace AssetTool
{
    [JsonAsset("IKRig_SetTransformEffector")]
    public class UIKRig_SetTransformEffector : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_SetTransform")]
    public class UIKRig_SetTransform : UIKRigSolver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}