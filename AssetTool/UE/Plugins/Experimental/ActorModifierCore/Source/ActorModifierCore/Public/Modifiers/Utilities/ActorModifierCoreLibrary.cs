namespace AssetTool
{
    [JsonAsset("ActorModifierCoreLibrary")]
    public class UActorModifierCoreLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}