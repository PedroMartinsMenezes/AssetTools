namespace AssetTool
{
    [JsonAsset("AvaTranslucentPriorityModifierShared")]
    public class UAvaTranslucentPriorityModifierShared : UActorModifierCoreSharedObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}