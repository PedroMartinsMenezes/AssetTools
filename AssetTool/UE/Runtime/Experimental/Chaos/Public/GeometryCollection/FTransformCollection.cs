namespace AssetTool
{
    public class FTransformCollection : FManagedArrayCollection
    {
        [Location("void FTransformCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}