namespace AssetTool.Chaos
{
    public class TImplicitObjectTransformed3<T> : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
