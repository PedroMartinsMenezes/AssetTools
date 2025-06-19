namespace AssetTool
{
    [JsonAsset("ActorModifierCoreLibrary")]
    public class UActorModifierCoreLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}