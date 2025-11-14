namespace AssetTool
{
    [JsonAsset("BlueprintExtension")]
    public class UBlueprintExtension : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}