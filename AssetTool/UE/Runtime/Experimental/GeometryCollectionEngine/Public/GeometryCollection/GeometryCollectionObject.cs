namespace AssetTool
{
    [JsonAsset("GeometryCollection")]
    public class UGeometryCollection : UObject
    {
        public FGeometryCollection GeometryCollection;
        public List<List<FTransform>> DummyTransforms;
        public bool bIsCookedOrCooking;
        public bool bCooked;

        [Location("void UGeometryCollection::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.GeometryCollectionInDDC)
            {
                transfer.Move(ref GeometryCollection);
            }
            if (!transfer.Supports.AddedTimestampedGeometryComponentCache)
            {
                transfer.Move(ref DummyTransforms);
            }
            else
            {
                base.Move(transfer);
            }
            if (transfer.Supports.GeometryCollectionInDDC)
            {
                transfer.Move(ref bIsCookedOrCooking);
            }
            if (transfer.Supports.GeometryCollectionInDDCAndAsset)
            {
                transfer.Move(ref GeometryCollection);
            }
            if (transfer.GlobalObjects.CustomVer(FUE5MainStreamObjectVersion.Guid) == (int)FUE5MainStreamObjectVersion.Enums.GeometryCollectionNaniteData ||
                (transfer.Supports.GeometryCollectionNaniteCooked && !transfer.Supports.GeometryCollectionNaniteTransient))
            {
                throw new NotImplementedException("SerializeOldNaniteData(ChaosAr, this)");
            }
            if (transfer.Supports.GeometryCollectionNaniteTransient)
            {
                transfer.Move(ref bCooked);
                if (bCooked)
                {
                    throw new NotImplementedException("RenderData->Serialize(ChaosAr, *this)");
                }
            }

            return this;
        }
    }
}