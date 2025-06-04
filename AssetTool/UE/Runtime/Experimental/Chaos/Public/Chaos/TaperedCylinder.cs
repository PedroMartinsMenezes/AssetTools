namespace AssetTool.Chaos
{
    public class FTaperedCylinder : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
