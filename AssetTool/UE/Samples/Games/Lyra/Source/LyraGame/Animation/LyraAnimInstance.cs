namespace AssetTool
{
    [JsonAsset("LyraAnimInstance")]
    public class ULyraAnimInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}