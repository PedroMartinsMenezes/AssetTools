namespace AssetTool
{
    [JsonAsset("StretchGizmoHandleGroup")]
    public class UStretchGizmoHandleGroup : UGizmoHandleGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StretchGizmoHandleDragOperation")]
    public class UStretchGizmoHandleDragOperation : UViewportDragOperation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}