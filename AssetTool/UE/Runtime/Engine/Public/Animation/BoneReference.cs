namespace AssetTool
{
    public class FBoneReference : ITransferible
    {
        public FName BoneName;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref BoneName);
            return this;
        }
    }
}
