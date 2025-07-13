namespace AssetTool
{
    [JsonAsset("DirectLinkProxy")]
    public class UDirectLinkProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithRuntimeLibrary")]
    public class UDatasmithRuntimeLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}