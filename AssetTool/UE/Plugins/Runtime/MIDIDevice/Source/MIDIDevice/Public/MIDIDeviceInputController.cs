namespace AssetTool
{
    [JsonAsset("MIDIDeviceInputController")]
    public class UMIDIDeviceInputController : UMIDIDeviceControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}