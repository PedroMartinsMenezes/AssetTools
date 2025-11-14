namespace AssetTool
{
    [JsonAsset("SkeletalControlLibrary")]
    public class USkeletalControlLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}