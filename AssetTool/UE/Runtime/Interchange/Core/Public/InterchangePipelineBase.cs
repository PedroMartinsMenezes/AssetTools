namespace AssetTool
{
    [JsonAsset("InterchangePipelineBase")]
    public class UInterchangePipelineBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}