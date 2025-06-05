namespace AssetTool.Chaos
{
    public class FTriangleMeshImplicitObject : FImplicitObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
