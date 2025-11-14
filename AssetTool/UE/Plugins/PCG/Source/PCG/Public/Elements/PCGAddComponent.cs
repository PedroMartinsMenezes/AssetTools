namespace AssetTool
{
    [JsonAsset("PCGAddComponentSettings")]
    public class UPCGAddComponentSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}