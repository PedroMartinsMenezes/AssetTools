namespace AssetTool
{
    [JsonAsset("DirectLinkTestLibrary")]
    public class UDirectLinkTestLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}