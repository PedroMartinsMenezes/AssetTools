namespace AssetTool
{
    [JsonAsset("AvaTranslucentPriorityModifierShared")]
    public class UAvaTranslucentPriorityModifierShared : UActorModifierCoreSharedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}