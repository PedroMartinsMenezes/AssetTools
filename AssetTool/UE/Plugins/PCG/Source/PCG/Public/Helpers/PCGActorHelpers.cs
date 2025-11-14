namespace AssetTool
{
    [JsonAsset("PCGActorHelpers")]
    public class UPCGActorHelpers : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}