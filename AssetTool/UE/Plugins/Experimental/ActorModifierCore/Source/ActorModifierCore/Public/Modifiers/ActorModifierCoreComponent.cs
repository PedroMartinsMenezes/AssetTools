namespace AssetTool
{
    [JsonAsset("ActorModifierCoreComponent")]
    public class UActorModifierCoreComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}