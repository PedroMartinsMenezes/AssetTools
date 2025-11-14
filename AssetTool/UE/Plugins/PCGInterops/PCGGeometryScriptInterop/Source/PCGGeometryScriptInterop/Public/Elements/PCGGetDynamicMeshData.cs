namespace AssetTool
{
    [JsonAsset("PCGGetDynamicMeshDataSettings")]
    public class UPCGGetDynamicMeshDataSettings : UPCGDataFromActorSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}