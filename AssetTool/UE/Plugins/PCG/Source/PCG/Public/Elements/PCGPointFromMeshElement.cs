namespace AssetTool
{
    [JsonAsset("PCGPointFromMeshSettings")]
    public class UPCGPointFromMeshSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}