namespace AssetTool
{
    [JsonAsset("DataflowBlueprintLibrary")]
    public class UDataflowBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}