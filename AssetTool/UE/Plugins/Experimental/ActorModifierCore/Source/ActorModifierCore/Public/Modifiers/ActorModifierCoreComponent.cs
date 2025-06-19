namespace AssetTool
{
    [JsonAsset("ActorModifierCoreComponent")]
    public class UActorModifierCoreComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}