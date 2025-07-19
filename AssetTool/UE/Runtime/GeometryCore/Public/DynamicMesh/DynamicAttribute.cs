namespace AssetTool.Geometry
{
    public class TDynamicAttributeBase : ITransferible
    {
        public FString Name;

        public virtual ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.DynamicMeshAttributesWeightMapsAndNames)
            {
                transfer.Move(ref Name);
            }
            return this;
        }
    }
}
