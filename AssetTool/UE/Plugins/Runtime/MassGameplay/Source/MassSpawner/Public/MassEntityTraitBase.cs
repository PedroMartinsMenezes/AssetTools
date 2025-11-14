namespace AssetTool
{
    [JsonAsset("MassEntityTraitBase")]
    public class UMassEntityTraitBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}