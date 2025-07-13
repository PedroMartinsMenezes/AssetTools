namespace AssetTool
{
    [JsonAsset("MassEntityTraitBase")]
    public class UMassEntityTraitBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}