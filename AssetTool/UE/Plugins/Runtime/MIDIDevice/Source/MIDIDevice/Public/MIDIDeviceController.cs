namespace AssetTool
{
    [JsonAsset("MIDIDeviceController")]
    public class UMIDIDeviceController : UMIDIDeviceControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}