namespace AssetTool
{
    [JsonAsset("AnimBlueprintSettings")]
    public class UAnimBlueprintSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}