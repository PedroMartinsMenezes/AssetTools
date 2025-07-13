namespace AssetTool
{
    [JsonAsset("AnimationBlueprintLibrary")]
    public class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}