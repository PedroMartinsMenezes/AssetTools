namespace AssetTool
{
    [JsonAsset("SequenceRecordingBase")]
    public class USequenceRecordingBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}