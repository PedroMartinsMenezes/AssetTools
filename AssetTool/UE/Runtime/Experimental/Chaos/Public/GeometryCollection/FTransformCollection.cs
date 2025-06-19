namespace AssetTool
{
    public class FTransformCollection : FManagedArrayCollection
    {
        [Location("void FTransformCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }
}