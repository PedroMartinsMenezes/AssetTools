namespace AssetTool
{
    [JsonAsset("PCGGetBoundsSettings")]
    public class UPCGGetBoundsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}