namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprint")]
    public class UActorModifierCoreBlueprint : UBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}