namespace AssetTool
{
    [JsonAsset("SkeletalControlLibrary")]
    public class USkeletalControlLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}