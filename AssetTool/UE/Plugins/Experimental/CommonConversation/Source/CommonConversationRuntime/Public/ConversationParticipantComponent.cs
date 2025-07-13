namespace AssetTool
{
    [JsonAsset("ConversationParticipantComponent")]
    public class UConversationParticipantComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}