namespace AssetTool
{
    [JsonAsset("PCGPointFromMeshSettings")]
    public class UPCGPointFromMeshSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}