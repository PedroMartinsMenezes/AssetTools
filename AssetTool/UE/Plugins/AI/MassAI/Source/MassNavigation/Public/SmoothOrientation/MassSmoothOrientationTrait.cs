namespace AssetTool
{
    [JsonAsset("MassSmoothOrientationTrait")]
    public class UMassSmoothOrientationTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}