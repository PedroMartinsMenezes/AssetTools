namespace AssetTool
{
    [JsonAsset("PCGPointFromMeshSettings")]
    public class UPCGPointFromMeshSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}