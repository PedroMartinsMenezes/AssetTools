namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBase")]
    public class UActorModifierCoreBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}