namespace AssetTool
{
    [JsonAsset("RawInputFunctionLibrary")]
    public class URawInputFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}