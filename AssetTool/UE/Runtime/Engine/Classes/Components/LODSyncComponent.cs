namespace AssetTool
{
    [JsonAsset("LODSyncComponent")]
    public class ULODSyncComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}