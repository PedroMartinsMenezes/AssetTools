namespace AssetTool.Chaos
{
    public class FTriangleMeshImplicitObject : FImplicitObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
