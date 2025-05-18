namespace AssetTool
{
    [JsonAsset("AvaTransformModifierShared")]
    public class UAvaTransformModifierShared : UActorModifierCoreSharedObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}