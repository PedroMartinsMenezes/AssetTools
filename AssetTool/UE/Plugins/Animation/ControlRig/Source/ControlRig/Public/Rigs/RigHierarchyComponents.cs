namespace AssetTool
{
    public class FRigBaseComponent : ITransferable
    {
        public FRigComponentKey Key;

        [Location("void FRigBaseComponent::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            return this;
        }
    }
}
