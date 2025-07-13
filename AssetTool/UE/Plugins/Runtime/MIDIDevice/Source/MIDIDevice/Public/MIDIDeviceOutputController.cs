namespace AssetTool
{
    [JsonAsset("MIDIDeviceOutputController")]
    public class UMIDIDeviceOutputController : UMIDIDeviceControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}