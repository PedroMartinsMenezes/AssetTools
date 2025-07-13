namespace AssetTool
{
    [JsonAsset("MassSimpleMovementTrait")]
    public class UMassSimpleMovementTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassSimpleMovementProcessor")]
    public class UMassSimpleMovementProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}