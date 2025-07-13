namespace AssetTool
{
    [JsonAsset("AsyncTask_OpenMrcVidCaptureFeedBase")]
    public class UAsyncTask_OpenMrcVidCaptureFeedBase : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncTask_OpenMrcVidCaptureDevice")]
    public class UAsyncTask_OpenMrcVidCaptureDevice : UAsyncTask_OpenMrcVidCaptureFeedBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncTask_OpenMrcVidCaptureFeed")]
    public class UAsyncTask_OpenMrcVidCaptureFeed : UAsyncTask_OpenMrcVidCaptureFeedBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}