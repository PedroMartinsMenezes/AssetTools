namespace AssetTool
{
    [JsonAsset("MassCrowdReplicator")]
    public class UMassCrowdReplicator : UMassReplicatorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}