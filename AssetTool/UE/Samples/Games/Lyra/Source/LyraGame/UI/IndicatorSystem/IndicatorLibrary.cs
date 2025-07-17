namespace AssetTool
{
    [JsonAsset("IndicatorLibrary")]
    public class UIndicatorLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}