namespace AssetTool.Geometry
{
    public class TDynamicMeshScalarTriangleAttribute<RealType> : ITransferible where RealType : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    #region TDynamicMeshScalarTriangleAttribute
    public class TDynamicMeshTriangleAttributeInt32 : TDynamicAttributeBase, ITransferible<FCompactMaps, bool>
    {
        public TDynamicVector<TInt32> AttribValues;
        public FBool bUseCompression;

        [Location("void Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression) at 458")]
        public ITransferible Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
        {
            base.Move(transfer);
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref AttribValues);
            }
            else
            {
                transfer.Move(ref bUseCompression);
                transfer.Move(ref AttribValues, true, bUseCompression);
            }
            return this;
        }

        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
