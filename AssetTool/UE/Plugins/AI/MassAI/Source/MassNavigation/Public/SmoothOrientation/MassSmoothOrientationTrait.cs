namespace AssetTool
{
    [JsonAsset("MassSmoothOrientationTrait")]
    public class UMassSmoothOrientationTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}