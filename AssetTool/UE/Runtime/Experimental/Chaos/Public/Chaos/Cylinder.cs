namespace AssetTool.Chaos
{
    public class FCylinder : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
