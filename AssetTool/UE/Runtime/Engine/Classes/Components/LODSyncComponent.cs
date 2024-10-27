namespace AssetTool
{
    [JsonAsset("LODSyncComponent")]
    public class ULODSyncComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}