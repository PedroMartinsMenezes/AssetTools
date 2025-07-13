namespace AssetTool
{
    [JsonAsset("MIDIDeviceControllerBase")]
    public class UMIDIDeviceControllerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}