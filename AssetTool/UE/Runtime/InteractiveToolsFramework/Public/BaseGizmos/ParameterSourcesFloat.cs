namespace AssetTool
{
    [JsonAsset("GizmoBaseFloatParameterSource")]
    public class UGizmoBaseFloatParameterSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoLocalFloatParameterSource")]
    public class UGizmoLocalFloatParameterSource : UGizmoBaseFloatParameterSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}