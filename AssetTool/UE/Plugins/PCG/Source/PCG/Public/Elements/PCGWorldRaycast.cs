namespace AssetTool
{
    [JsonAsset("PCGWorldRaycastElementSettings")]
    public class UPCGWorldRaycastElementSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}