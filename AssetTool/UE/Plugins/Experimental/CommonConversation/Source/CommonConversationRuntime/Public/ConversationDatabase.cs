namespace AssetTool
{
    [JsonAsset("ConversationDatabase")]
    public class UConversationDatabase : UPrimaryDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}