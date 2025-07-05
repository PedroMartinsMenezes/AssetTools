namespace AssetTool
{
    [TransferibleStruct("MidiEvent")]
    public class FMidiEvent : ITransferible
    {
        public int32 Tick;
        public FMidiMsg Message;

        [Location("bool FMidiEvent::Serialize(FArchive& Archive)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Tick);
            transfer.Move(ref Message);
            return this;
        }
    }
}
