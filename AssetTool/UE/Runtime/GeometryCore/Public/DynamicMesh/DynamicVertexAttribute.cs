namespace AssetTool.Geometry
{
    public class TDynamicMeshVertexAttribute<AttribValueType, AttribDimension> :
        TDynamicVertexAttribute<AttribValueType, AttribDimension, FDynamicMesh3>
        where AttribValueType : ITransferable, new()
        where AttribDimension : ConstInt
    {
    }

    public class TDynamicVertexAttribute<AttribValueType, AttribDimension, ParentType> : TDynamicAttributeBase
        where AttribValueType : ITransferable, new()
        where AttribDimension : ConstInt
        where ParentType : ITransferable, new()
    {
        public bool bUseCompression;
        public TDynamicVector<AttribValueType> AttribValues;

        [Location("void Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public override ITransferable Move(Transfer transfer)
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
    }
}
