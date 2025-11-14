namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprintBase")]
    public class UActorModifierCoreBlueprintBase : UActorModifierCoreBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}