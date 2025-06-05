namespace AssetTool
{
    [JsonAsset("BlueprintExtension")]
    public class UBlueprintExtension : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}