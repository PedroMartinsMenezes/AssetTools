namespace AssetTool
{
    [JsonAsset("FunctionalTestUtilityLibrary")]
    public class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}