namespace AssetTool
{
    [JsonAsset("AnimBlueprintExtension")]
    public class UAnimBlueprintExtension : UBlueprintExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}