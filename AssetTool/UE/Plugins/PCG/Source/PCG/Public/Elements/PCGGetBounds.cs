namespace AssetTool
{
    [JsonAsset("PCGGetBoundsSettings")]
    public class UPCGGetBoundsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}