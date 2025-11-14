namespace AssetTool.Chaos
{
    public class FCylinder : FImplicitObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
