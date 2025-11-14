namespace AssetTool
{
    [JsonAsset("PCGAppendMeshesFromPointsSettings")]
    public class UPCGAppendMeshesFromPointsSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}