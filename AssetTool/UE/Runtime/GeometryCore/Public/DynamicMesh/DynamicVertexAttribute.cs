namespace AssetTool.Geometry
{
    public class TDynamicMeshVertexAttribute<AttribValueType, AttribDimension> :
        TDynamicVertexAttribute<AttribValueType, AttribDimension, FDynamicMesh3>
        where AttribValueType : ITransferible, new()
        where AttribDimension : ConstInt
    {
    }

    public class TDynamicVertexAttribute<AttribValueType, AttribDimension, ParentType> : TDynamicAttributeBase
        where AttribValueType : ITransferible, new()
        where AttribDimension : ConstInt
        where ParentType : ITransferible, new()
    {
        public bool bUseCompression;
        public TDynamicVector<AttribValueType> AttribValues;

        [Location("void Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public override ITransferible Move(Transfer transfer)
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
