namespace AssetTool
{
    [JsonAsset("StageAppFunctionLibrary")]
    public class UStageAppFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}