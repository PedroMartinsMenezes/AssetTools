namespace AssetTool
{
    [JsonAsset("AnimBlueprintExtension")]
    public class UAnimBlueprintExtension : UBlueprintExtension
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}