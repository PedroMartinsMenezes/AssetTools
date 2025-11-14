namespace AssetTool
{
    public class FTransformCollection : FManagedArrayCollection
    {
        [Location("void FTransformCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }
}