namespace AssetTool.Chaos
{
    public class TImplicitObjectTransformed3<T> : FImplicitObject
    {
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            return this;
        }
    }
}
