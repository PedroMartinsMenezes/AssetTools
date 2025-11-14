namespace AssetTool
{
    [JsonAsset("AnimBlueprintExtension")]
    public class UAnimBlueprintExtension : UBlueprintExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}