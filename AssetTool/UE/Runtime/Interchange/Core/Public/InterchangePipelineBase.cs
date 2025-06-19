namespace AssetTool
{
    [JsonAsset("InterchangePipelineBase")]
    public class UInterchangePipelineBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}