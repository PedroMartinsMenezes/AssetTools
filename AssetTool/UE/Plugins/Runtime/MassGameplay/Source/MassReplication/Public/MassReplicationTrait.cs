namespace AssetTool
{
    [JsonAsset("MassReplicationTrait")]
    public class UMassReplicationTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}