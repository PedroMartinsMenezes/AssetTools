namespace AssetTool
{
    [JsonAsset("ImportanceSamplingLibrary")]
    public class UImportanceSamplingLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}