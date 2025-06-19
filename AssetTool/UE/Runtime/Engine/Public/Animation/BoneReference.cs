namespace AssetTool
{
    public class FBoneReference : ITransferible
    {
        public FName BoneName;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BoneName);
            return this;
        }
    }
}
