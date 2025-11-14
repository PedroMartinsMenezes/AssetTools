namespace AssetTool
{
    [JsonAsset("PCGGraphInputOutputSettings")]
    public class UPCGGraphInputOutputSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}