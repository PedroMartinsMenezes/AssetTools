namespace AssetTool
{
    [JsonAsset("MidiStepSequence")]
    public class UMidiStepSequence : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}