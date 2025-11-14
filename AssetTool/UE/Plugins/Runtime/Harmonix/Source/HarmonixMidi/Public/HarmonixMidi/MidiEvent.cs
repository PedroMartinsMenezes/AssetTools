namespace AssetTool
{
    [TransferableStruct("MidiEvent")]
    public class FMidiEvent : ITransferable
    {
        public int32 Tick;
        public FMidiMsg Message;

        [Location("bool FMidiEvent::Serialize(FArchive& Archive)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Tick);
            transfer.Move(ref Message);
            return this;
        }
    }
}
