namespace AssetTool
{
    [JsonAsset("DataflowBaseContent")]
    public class UDataflowBaseContent : UDataflowContextObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowSkeletalContent")]
    public class UDataflowSkeletalContent : UDataflowBaseContent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}