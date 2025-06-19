namespace AssetTool
{
    [JsonAsset("FleshAsset")]
    public class UFleshAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowFleshContent")]
    public class UDataflowFleshContent : UDataflowSkeletalContent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}