namespace AssetTool
{
    [JsonAsset("GizmoHandleGroup")]
    public class UGizmoHandleGroup : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AxisGizmoHandleGroup")]
    public class UAxisGizmoHandleGroup : UGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}