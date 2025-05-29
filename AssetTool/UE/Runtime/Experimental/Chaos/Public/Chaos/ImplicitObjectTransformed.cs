namespace AssetTool
{
    public class TImplicitObjectTransformed3<T> : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
