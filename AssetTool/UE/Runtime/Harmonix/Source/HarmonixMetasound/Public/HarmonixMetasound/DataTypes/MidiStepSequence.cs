namespace AssetTool
{
    [JsonAsset("MidiStepSequence")]
    public class UMidiStepSequence : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}