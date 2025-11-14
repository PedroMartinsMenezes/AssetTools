namespace AssetTool.Chaos
{
    public class FTaperedCapsule : FImplicitObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
