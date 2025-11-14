namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprint")]
    public class UActorModifierCoreBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}