using System.Diagnostics;

namespace AssetTool.Geometry
{
    #region TDynamicMeshScalarTriangleAttribute
    [DebuggerDisplay("{AttribValues}")]
    public class TDynamicMeshTriangleAttributeInt32 : TDynamicAttributeBase, ITransferable<FCompactMaps, bool>
    {
        public TDynamicVector<TInt32> AttribValues;
        public bool bUseCompression;

        [Location("void Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression) at 458")]
        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps, bool useCompression)
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

        public override ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
