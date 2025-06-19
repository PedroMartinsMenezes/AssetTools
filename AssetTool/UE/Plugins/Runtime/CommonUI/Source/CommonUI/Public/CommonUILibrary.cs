namespace AssetTool
{
    [JsonAsset("CommonUILibrary")]
    public class UCommonUILibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}