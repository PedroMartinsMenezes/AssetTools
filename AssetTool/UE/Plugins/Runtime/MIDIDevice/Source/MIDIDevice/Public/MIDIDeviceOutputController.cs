namespace AssetTool
{
    [JsonAsset("MIDIDeviceOutputController")]
    public class UMIDIDeviceOutputController : UMIDIDeviceControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}