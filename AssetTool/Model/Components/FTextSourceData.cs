using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{SourceString}")]
    public class FTextSourceData : ITransferable
    {
        public FString SourceString;
        public UInt32 SourceStringMetaData;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref SourceString);
            transfer.Move(ref SourceStringMetaData);
            return this;
        }
    }
}
