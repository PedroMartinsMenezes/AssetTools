namespace AssetTool
{
    [JsonAsset("AvaVisibilityModifierShared")]
    public class UAvaVisibilityModifierShared : UActorModifierCoreSharedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}