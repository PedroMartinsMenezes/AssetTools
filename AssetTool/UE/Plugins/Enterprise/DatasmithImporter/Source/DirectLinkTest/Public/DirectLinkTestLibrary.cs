namespace AssetTool
{
    [JsonAsset("DirectLinkTestLibrary")]
    public class UDirectLinkTestLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}