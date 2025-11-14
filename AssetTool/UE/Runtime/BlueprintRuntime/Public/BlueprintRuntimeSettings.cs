namespace AssetTool
{
    [JsonAsset("BlueprintRuntimeSettings")]
    public class UBlueprintRuntimeSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}