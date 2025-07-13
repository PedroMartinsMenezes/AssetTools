namespace AssetTool
{
    [JsonAsset("MassLookAtTrait")]
    public class UMassLookAtTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}