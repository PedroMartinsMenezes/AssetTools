namespace AssetTool
{
    [JsonAsset("SunPositionFunctionLibrary")]
    public class USunPositionFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}