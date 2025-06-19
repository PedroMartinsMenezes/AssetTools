namespace AssetTool
{
    [JsonAsset("GizmoBaseVec2ParameterSource")]
    public class UGizmoBaseVec2ParameterSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoLocalVec2ParameterSource")]
    public class UGizmoLocalVec2ParameterSource : UGizmoBaseVec2ParameterSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}