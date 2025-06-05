namespace AssetTool
{
    [JsonAsset("AvaVisibilityModifierShared")]
    public class UAvaVisibilityModifierShared : UActorModifierCoreSharedObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}