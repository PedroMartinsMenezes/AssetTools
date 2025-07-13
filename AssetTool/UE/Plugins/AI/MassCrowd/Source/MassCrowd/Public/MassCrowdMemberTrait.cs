namespace AssetTool
{
    [JsonAsset("MassCrowdMemberTrait")]
    public class UMassCrowdMemberTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}