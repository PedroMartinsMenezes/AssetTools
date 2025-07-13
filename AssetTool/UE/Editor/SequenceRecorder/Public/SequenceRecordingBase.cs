namespace AssetTool
{
    [JsonAsset("SequenceRecordingBase")]
    public class USequenceRecordingBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}