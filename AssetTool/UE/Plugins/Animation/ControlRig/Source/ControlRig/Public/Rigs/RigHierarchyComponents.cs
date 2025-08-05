namespace AssetTool
{
    public class FRigBaseComponent : ITransferible
    {
        public FRigComponentKey Key;

        [Location("void FRigBaseComponent::Load(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            return this;
        }
    }
}
