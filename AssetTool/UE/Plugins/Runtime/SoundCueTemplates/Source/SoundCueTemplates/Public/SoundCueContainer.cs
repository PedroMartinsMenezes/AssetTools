namespace AssetTool
{
    [JsonAsset("SoundCueContainer")]
    public class USoundCueContainer : USoundCueTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}