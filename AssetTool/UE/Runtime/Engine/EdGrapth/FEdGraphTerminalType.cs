namespace AssetTool
{
    public class FEdGraphTerminalType : ITransferible
    {
        public FName TerminalCategory;
        public FString TerminalCategoryStr;
        public FName TerminalSubCategory;
        public FString TerminalSubCategoryStr;
        public FBool bTerminalIsConst;
        public FBool bTerminalIsWeakPointer;
        public FBool bTerminalIsUObjectWrapper;
        public UInt32 TerminalSubCategoryObject;

        [Location("FArchive& operator<<(FArchive& Ar, FEdGraphTerminalType& T)")]
        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.PinsStoreFName)
            {
                transfer.Move(ref TerminalCategory);
                transfer.Move(ref TerminalSubCategory);
            }
            else
            {
                transfer.Move(ref TerminalCategoryStr);
                transfer.Move(ref TerminalSubCategoryStr);
            }

            transfer.Move(ref TerminalSubCategoryObject);

            transfer.Move(ref bTerminalIsConst);
            transfer.Move(ref bTerminalIsWeakPointer);
            if (transfer.Supports.PinTypeIncludesUObjectWrapperFlag)
            {
                transfer.Move(ref bTerminalIsUObjectWrapper);
            }
            return this;
        }
    }
}
