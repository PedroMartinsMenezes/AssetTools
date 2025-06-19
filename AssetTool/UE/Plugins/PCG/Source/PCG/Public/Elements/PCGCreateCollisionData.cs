namespace AssetTool
{
    [JsonAsset("PCGCreateCollisionDataSettings")]
    public class UPCGCreateCollisionDataSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}