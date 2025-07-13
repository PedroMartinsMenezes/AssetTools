namespace AssetTool
{
    [JsonAsset("SequentialPartialNetBlobHandlerConfig")]
    public class USequentialPartialNetBlobHandlerConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SequentialPartialNetBlobHandler")]
    public class USequentialPartialNetBlobHandler : UNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}