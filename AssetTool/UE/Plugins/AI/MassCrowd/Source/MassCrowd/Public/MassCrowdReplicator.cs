namespace AssetTool
{
    [JsonAsset("MassCrowdReplicator")]
    public class UMassCrowdReplicator : UMassReplicatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}