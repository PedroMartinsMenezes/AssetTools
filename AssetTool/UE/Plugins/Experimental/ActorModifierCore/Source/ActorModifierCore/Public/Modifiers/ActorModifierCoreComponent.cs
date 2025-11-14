namespace AssetTool
{
    [JsonAsset("ActorModifierCoreComponent")]
    public class UActorModifierCoreComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}