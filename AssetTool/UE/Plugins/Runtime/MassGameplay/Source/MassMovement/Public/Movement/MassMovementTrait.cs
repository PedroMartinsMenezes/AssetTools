namespace AssetTool
{
    [JsonAsset("MassMovementTrait")]
    public class UMassMovementTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}