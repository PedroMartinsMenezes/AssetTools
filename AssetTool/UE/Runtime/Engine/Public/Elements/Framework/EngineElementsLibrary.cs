namespace AssetTool
{
    [JsonAsset("EngineElementsLibrary")]
    public class UEngineElementsLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}