namespace AssetTool
{
    [JsonAsset("DMXModulator")]
    public class UDMXModulator : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}