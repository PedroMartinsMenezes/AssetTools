namespace AssetTool
{
    [JsonAsset("SoundCueTemplate")]
    public class USoundCueTemplate : USoundCue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}