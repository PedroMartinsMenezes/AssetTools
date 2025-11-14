namespace AssetTool
{
    [JsonAsset("AnimSequencerInstance")]
    public class UAnimSequencerInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}