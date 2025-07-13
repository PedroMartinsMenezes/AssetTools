namespace AssetTool
{
    [JsonAsset("PCGGetDynamicMeshDataSettings")]
    public class UPCGGetDynamicMeshDataSettings : UPCGDataFromActorSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}