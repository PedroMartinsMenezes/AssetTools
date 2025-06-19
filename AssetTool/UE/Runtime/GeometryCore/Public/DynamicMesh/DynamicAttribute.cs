namespace AssetTool.Geometry
{
    public class TDynamicAttributeBase : ITransferible
    {
        public FString Name;

        public virtual ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Name);
            return this;
        }
    }
}
