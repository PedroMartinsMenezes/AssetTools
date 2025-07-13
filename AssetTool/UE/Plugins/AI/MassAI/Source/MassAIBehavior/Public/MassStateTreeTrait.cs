namespace AssetTool
{
    [JsonAsset("MassStateTreeTrait")]
    public class UMassStateTreeTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}