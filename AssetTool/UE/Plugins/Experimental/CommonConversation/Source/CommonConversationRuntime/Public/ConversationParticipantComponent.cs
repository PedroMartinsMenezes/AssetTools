namespace AssetTool
{
    [JsonAsset("ConversationParticipantComponent")]
    public class UConversationParticipantComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}