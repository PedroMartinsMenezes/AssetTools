namespace AssetTool
{
    [JsonAsset("MediaSequenceRecorderSettings")]
    public class UMediaSequenceRecorderSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}