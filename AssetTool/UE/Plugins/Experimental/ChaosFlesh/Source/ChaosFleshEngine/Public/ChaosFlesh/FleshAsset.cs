namespace AssetTool
{
    [JsonAsset("FleshAsset")]
    public class UFleshAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataflowFleshContent")]
    public class UDataflowFleshContent : UDataflowSkeletalContent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}