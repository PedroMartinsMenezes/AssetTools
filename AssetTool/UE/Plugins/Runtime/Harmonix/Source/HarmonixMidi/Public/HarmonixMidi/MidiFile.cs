namespace AssetTool
{
    [JsonAsset("MidiFile")]
    public class UMidiFile : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}