namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprintBase")]
    public class UActorModifierCoreBlueprintBase : UActorModifierCoreBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}