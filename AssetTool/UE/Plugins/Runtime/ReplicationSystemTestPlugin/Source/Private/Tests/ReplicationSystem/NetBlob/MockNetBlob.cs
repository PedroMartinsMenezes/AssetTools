namespace AssetTool
{
    [JsonAsset("MockNetBlobHandler")]
    public class UMockNetBlobHandler : UNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockSequentialPartialNetBlobHandlerConfig")]
    public class UMockSequentialPartialNetBlobHandlerConfig : USequentialPartialNetBlobHandlerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockSequentialPartialNetBlobHandler")]
    public class UMockSequentialPartialNetBlobHandler : USequentialPartialNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}