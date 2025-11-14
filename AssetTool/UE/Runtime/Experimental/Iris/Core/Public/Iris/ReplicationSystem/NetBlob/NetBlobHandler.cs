namespace AssetTool
{
    [JsonAsset("NetBlobHandler")]
    public class UNetBlobHandler : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}