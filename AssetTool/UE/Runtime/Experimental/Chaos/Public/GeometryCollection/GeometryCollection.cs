namespace AssetTool
{
    public class FGeometryCollection : FTransformCollection
    {
        [Location("void FGeometryCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }
}