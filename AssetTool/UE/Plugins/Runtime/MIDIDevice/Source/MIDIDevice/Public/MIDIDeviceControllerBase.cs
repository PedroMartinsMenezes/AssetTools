namespace AssetTool
{
    [JsonAsset("MIDIDeviceControllerBase")]
    public class UMIDIDeviceControllerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}