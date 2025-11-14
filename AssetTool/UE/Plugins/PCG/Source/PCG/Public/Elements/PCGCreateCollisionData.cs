namespace AssetTool
{
    [JsonAsset("PCGCreateCollisionDataSettings")]
    public class UPCGCreateCollisionDataSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}