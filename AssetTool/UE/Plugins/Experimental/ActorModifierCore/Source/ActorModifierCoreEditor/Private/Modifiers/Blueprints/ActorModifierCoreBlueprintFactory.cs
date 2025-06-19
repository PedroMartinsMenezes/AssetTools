namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBlueprintFactory")]
    public class UActorModifierCoreBlueprintFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}