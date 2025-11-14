namespace AssetTool
{
    public class FBoneReference : ITransferable
    {
        public FName BoneName;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BoneName);
            return this;
        }
    }
}
