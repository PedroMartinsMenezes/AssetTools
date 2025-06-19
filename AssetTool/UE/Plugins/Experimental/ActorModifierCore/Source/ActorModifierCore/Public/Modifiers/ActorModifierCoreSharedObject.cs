namespace AssetTool
{
    [JsonAsset("ActorModifierCoreSharedObject")]
    public class UActorModifierCoreSharedObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}