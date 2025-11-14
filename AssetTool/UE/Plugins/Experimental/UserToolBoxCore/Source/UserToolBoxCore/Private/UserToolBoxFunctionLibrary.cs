namespace AssetTool
{
    [JsonAsset("UserToolBoxFunctionLibrary")]
    public class UUserToolBoxFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}