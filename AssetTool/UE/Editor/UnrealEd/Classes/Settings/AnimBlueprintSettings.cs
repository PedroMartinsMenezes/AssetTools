namespace AssetTool
{
    [JsonAsset("AnimBlueprintSettings")]
    public class UAnimBlueprintSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}