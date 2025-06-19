namespace AssetTool
{
    [JsonAsset("PCGFunctionPrototypes")]
    public class UPCGFunctionPrototypes : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}