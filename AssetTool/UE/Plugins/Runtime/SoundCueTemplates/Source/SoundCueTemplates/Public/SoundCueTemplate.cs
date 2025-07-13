namespace AssetTool
{
    [JsonAsset("SoundCueTemplate")]
    public class USoundCueTemplate : USoundCue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}