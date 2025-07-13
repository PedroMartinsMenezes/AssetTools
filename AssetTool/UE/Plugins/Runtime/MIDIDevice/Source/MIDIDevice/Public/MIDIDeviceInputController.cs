namespace AssetTool
{
    [JsonAsset("MIDIDeviceInputController")]
    public class UMIDIDeviceInputController : UMIDIDeviceControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}