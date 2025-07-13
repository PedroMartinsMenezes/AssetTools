namespace AssetTool
{
    [JsonAsset("MrcUtilLibrary")]
    public class UMrcUtilLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}