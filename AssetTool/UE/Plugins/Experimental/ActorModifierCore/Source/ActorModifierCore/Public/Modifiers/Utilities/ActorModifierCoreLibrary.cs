namespace AssetTool
{
    [JsonAsset("ActorModifierCoreLibrary")]
    public class UActorModifierCoreLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}