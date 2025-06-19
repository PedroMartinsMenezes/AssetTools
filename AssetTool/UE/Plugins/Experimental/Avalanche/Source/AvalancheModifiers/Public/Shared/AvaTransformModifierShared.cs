namespace AssetTool
{
    [JsonAsset("AvaTransformModifierShared")]
    public class UAvaTransformModifierShared : UActorModifierCoreSharedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}