namespace AssetTool
{
    [JsonAsset("MidiFile")]
    public class UMidiFile : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}