namespace AssetTool
{
    [JsonAsset("LyraAnimInstance")]
    public class ULyraAnimInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}