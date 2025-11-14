namespace AssetTool
{
    [JsonAsset("AnimInstance")]
    public class UAnimInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}