namespace AssetTool
{
    [JsonAsset("AnimSequencerInstance")]
    public class UAnimSequencerInstance : UAnimInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}