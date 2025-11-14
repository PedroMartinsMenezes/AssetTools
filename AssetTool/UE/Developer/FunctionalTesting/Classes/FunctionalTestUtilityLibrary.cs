namespace AssetTool
{
    [JsonAsset("FunctionalTestUtilityLibrary")]
    public class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}