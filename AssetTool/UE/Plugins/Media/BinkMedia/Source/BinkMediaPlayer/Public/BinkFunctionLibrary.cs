namespace AssetTool
{
    [JsonAsset("BinkFunctionLibrary")]
    public class UBinkFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}