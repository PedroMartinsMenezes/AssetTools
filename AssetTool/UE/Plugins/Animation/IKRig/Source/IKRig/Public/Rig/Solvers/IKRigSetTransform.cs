namespace AssetTool
{
    [JsonAsset("IKRigSetTransformController")]
    public class UIKRigSetTransformController : UIKRigSolverControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_SetTransformEffector")]
    public class UIKRig_SetTransformEffector : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IKRig_SetTransform")]
    public class UIKRig_SetTransform : UIKRigSolver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}