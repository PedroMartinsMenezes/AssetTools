namespace AssetTool
{
    [JsonAsset("DMValueDefinitionLibrary")]
    public class UDMValueDefinitionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}