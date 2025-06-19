namespace AssetTool
{
    [JsonAsset("BTFunctionLibrary")]
    public class UBTFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}