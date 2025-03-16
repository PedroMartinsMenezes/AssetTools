namespace AssetTool
{
    [JsonAsset("AnimInstance")]
    public class UAnimInstance : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}