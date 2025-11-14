namespace AssetTool
{
    [JsonAsset("ActorModifierCoreSharedObject")]
    public class UActorModifierCoreSharedObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}