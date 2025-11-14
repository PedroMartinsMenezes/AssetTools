namespace AssetTool
{
    [JsonAsset("PivotTransformGizmo")]
    public class APivotTransformGizmo : ABaseTransformGizmo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PivotTranslationGizmoHandleGroup")]
    public class UPivotTranslationGizmoHandleGroup : UAxisGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PivotScaleGizmoHandleGroup")]
    public class UPivotScaleGizmoHandleGroup : UAxisGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PivotPlaneTranslationGizmoHandleGroup")]
    public class UPivotPlaneTranslationGizmoHandleGroup : UAxisGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PivotRotationGizmoHandleGroup")]
    public class UPivotRotationGizmoHandleGroup : UAxisGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}