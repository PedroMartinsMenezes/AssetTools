namespace AssetTool.Chaos
{
    public class FHeightField : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
