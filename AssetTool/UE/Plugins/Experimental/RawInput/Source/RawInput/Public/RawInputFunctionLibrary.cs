namespace AssetTool
{
    [JsonAsset("RawInputFunctionLibrary")]
    public class URawInputFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}