namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBase")]
    public class UActorModifierCoreBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}