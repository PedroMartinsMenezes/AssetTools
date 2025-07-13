namespace AssetTool
{
    [JsonAsset("ARUtilitiesFunctionLibrary")]
    public class UARUtilitiesFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}