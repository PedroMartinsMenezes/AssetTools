namespace AssetTool
{
    [JsonAsset("LODSyncComponent")]
    public class ULODSyncComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}