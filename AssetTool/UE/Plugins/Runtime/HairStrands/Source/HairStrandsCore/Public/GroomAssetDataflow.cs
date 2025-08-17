namespace AssetTool
{
    [JsonAsset("DataflowGroomContent")]
    public class UDataflowGroomContent : UDataflowSkeletalContent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}