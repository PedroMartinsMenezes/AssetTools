namespace AssetTool
{
    [JsonAsset("PCGGraphInputOutputSettings")]
    public class UPCGGraphInputOutputSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}