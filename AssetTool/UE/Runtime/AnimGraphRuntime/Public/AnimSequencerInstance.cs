namespace AssetTool
{
    [JsonAsset("AnimSequencerInstance")]
    public class UAnimSequencerInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}