namespace AssetTool.Chaos
{
    public class FTaperedCylinder : FImplicitObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
