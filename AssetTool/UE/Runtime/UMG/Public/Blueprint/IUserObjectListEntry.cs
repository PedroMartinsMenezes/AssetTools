namespace AssetTool
{
    [JsonAsset("UserObjectListEntryLibrary")]
    public class UUserObjectListEntryLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}