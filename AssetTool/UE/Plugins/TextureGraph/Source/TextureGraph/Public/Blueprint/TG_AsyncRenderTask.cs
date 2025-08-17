namespace AssetTool
{
    [JsonAsset("TG_AsyncRenderTaskBase")]
    public class UTG_AsyncRenderTaskBase : UTG_AsyncTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TG_AsyncRenderTask")]
    public class UTG_AsyncRenderTask : UTG_AsyncRenderTaskBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}