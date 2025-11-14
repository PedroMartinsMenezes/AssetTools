namespace AssetTool
{
    [JsonAsset("UniformScaleGizmoHandleGroup")]
    public class UUniformScaleGizmoHandleGroup : UGizmoHandleGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}