namespace AssetTool
{
    [JsonAsset("MidiFileFactory")]
    public class UMidiFileFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}