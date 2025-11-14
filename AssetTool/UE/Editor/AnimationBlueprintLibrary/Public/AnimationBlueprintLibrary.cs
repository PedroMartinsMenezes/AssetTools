namespace AssetTool
{
    [JsonAsset("AnimationBlueprintLibrary")]
    public class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}