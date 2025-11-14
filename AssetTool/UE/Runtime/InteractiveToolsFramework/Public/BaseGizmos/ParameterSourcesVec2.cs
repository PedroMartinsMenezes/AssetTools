namespace AssetTool
{
    [JsonAsset("GizmoBaseVec2ParameterSource")]
    public class UGizmoBaseVec2ParameterSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoLocalVec2ParameterSource")]
    public class UGizmoLocalVec2ParameterSource : UGizmoBaseVec2ParameterSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}