namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprintBase")]
    public class UActorModifierCoreBlueprintBase : UActorModifierCoreBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}