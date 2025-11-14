namespace AssetTool
{
    [JsonAsset("AnimationBlueprintEditorSettings")]
    public class UAnimationBlueprintEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}