namespace AssetTool
{
    [JsonAsset("PCGBoundsFromMeshSettings")]
    public class UPCGBoundsFromMeshSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}