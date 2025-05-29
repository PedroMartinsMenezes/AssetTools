namespace AssetTool
{
    public class TBox3<T> : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
