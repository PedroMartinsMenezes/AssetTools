namespace AssetTool
{
    [JsonAsset("DataflowBlueprintLibrary")]
    public class UDataflowBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}