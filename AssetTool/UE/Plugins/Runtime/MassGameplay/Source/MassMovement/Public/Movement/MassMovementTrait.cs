namespace AssetTool
{
    [JsonAsset("MassMovementTrait")]
    public class UMassMovementTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}