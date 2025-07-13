namespace AssetTool
{
    [JsonAsset("GroomBlueprintLibrary")]
    public class UGroomBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}