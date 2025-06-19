namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprint")]
    public class UActorModifierCoreBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}