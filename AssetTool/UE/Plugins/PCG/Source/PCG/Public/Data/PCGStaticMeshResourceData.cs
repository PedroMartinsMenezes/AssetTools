namespace AssetTool
{
    [JsonAsset("PCGStaticMeshResourceData")]
    public class UPCGStaticMeshResourceData : UPCGResourceData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}