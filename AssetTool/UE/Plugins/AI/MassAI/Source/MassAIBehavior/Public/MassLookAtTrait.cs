namespace AssetTool
{
    [JsonAsset("MassLookAtTrait")]
    public class UMassLookAtTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}