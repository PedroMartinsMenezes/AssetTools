namespace AssetTool
{
    [JsonAsset("MediaSequenceRecorderSettings")]
    public class UMediaSequenceRecorderSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}