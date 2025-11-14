namespace AssetTool
{
    [JsonAsset("StretchGizmoHandleGroup")]
    public class UStretchGizmoHandleGroup : UGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StretchGizmoHandleDragOperation")]
    public class UStretchGizmoHandleDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}