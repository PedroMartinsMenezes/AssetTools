namespace AssetTool
{
    [JsonAsset("UniformScaleGizmoHandleGroup")]
    public class UUniformScaleGizmoHandleGroup : UGizmoHandleGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}