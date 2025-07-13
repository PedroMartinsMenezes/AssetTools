namespace AssetTool
{
    [JsonAsset("ConversationDatabase")]
    public class UConversationDatabase : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}