namespace AssetTool
{
    [JsonAsset("AsyncCaptureScene")]
    public class UAsyncCaptureScene : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}