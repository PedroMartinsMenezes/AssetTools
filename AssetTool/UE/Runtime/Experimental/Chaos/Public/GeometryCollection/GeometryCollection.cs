namespace AssetTool
{
    public class FGeometryCollection : FTransformCollection
    {
        [Location("void FGeometryCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}