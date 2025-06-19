namespace AssetTool
{
    public class FGeometryCollection : FTransformCollection
    {
        [Location("void FGeometryCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}