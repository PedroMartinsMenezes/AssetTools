namespace AssetTool
{
    [JsonAsset("AvaTransformModifierShared")]
    public class UAvaTransformModifierShared : UActorModifierCoreSharedObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}