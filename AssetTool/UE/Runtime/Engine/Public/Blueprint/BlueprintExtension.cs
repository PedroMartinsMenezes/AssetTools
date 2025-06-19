namespace AssetTool
{
    [JsonAsset("BlueprintExtension")]
    public class UBlueprintExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}