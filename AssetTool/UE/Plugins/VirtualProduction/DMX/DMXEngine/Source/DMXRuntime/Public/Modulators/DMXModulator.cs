namespace AssetTool
{
    [JsonAsset("DMXModulator")]
    public class UDMXModulator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}