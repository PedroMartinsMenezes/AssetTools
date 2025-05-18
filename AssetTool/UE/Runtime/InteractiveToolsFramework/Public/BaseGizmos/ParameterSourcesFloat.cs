namespace AssetTool
{
    [JsonAsset("GizmoBaseFloatParameterSource")]
    public class UGizmoBaseFloatParameterSource : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoLocalFloatParameterSource")]
    public class UGizmoLocalFloatParameterSource : UGizmoBaseFloatParameterSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}