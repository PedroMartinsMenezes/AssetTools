namespace AssetTool.Chaos
{
    public class TImplicitObjectTransformed3<T> : FImplicitObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
