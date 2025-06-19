namespace AssetTool
{
    [JsonAsset("FunctionalTestUtilityLibrary")]
    public class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}