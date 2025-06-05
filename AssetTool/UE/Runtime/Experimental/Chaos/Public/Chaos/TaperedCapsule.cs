namespace AssetTool.Chaos
{
    public class FTaperedCapsule : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
