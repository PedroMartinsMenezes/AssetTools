namespace AssetTool
{
    public class FTextSourceData : ITransferible
    {
        public FString SourceString;
        public UInt32 SourceStringMetaData;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref SourceString);
            transfer.Move(ref SourceStringMetaData);
            return this;
        }
    }
}
