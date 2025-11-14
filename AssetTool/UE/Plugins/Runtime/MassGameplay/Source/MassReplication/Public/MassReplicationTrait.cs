namespace AssetTool
{
    [JsonAsset("MassReplicationTrait")]
    public class UMassReplicationTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}