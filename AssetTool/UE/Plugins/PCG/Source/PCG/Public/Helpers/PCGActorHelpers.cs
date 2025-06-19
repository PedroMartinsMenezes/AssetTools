namespace AssetTool
{
    [JsonAsset("PCGActorHelpers")]
    public class UPCGActorHelpers : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}