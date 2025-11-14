namespace AssetTool
{
    [JsonAsset("MockNetBlobHandler")]
    public class UMockNetBlobHandler : UNetBlobHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockSequentialPartialNetBlobHandlerConfig")]
    public class UMockSequentialPartialNetBlobHandlerConfig : USequentialPartialNetBlobHandlerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockSequentialPartialNetBlobHandler")]
    public class UMockSequentialPartialNetBlobHandler : USequentialPartialNetBlobHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}