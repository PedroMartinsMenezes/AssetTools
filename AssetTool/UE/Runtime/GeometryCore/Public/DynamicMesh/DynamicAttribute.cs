namespace AssetTool.Geometry
{
    public class TDynamicAttributeBase : ITransferable
    {
        public FString Name;

        [Location("friend FArchive& operator<<(FArchive& Ar, TDynamicAttributeBase<ParentType>& Attr)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.DynamicMeshAttributesWeightMapsAndNames)
            {
                transfer.Move(ref Name);
            }
            return this;
        }
    }
}
