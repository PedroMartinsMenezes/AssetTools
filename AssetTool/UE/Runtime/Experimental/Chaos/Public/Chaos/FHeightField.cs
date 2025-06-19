namespace AssetTool.Chaos
{
    public class FHeightField : FImplicitObject
    {
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            return this;
        }
    }
}
