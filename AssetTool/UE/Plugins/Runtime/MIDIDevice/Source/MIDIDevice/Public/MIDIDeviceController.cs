namespace AssetTool
{
    [JsonAsset("MIDIDeviceController")]
    public class UMIDIDeviceController : UMIDIDeviceControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}