namespace AssetTool
{
    [JsonAsset("SunPositionFunctionLibrary")]
    public class USunPositionFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}