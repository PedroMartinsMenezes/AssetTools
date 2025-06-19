namespace AssetTool
{
    [JsonAsset("BlueprintFunctionLibraryFactory")]
    public class UBlueprintFunctionLibraryFactory : UBlueprintFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}