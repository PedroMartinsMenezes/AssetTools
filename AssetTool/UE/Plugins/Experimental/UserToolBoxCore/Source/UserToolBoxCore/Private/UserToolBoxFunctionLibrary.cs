namespace AssetTool
{
    [JsonAsset("UserToolBoxFunctionLibrary")]
    public class UUserToolBoxFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}