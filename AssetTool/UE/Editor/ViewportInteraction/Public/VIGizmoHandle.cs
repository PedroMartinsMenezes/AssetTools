namespace AssetTool
{
    [JsonAsset("GizmoHandleGroup")]
    public class UGizmoHandleGroup : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AxisGizmoHandleGroup")]
    public class UAxisGizmoHandleGroup : UGizmoHandleGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}