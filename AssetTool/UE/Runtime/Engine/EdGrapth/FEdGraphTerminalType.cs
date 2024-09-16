namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, FEdGraphTerminalType& T)")]
    public class FEdGraphTerminalType
    {
        public FName TerminalCategory;
        public FString TerminalCategoryStr;
        public FName TerminalSubCategory;
        public FString TerminalSubCategoryStr;
        public FBool bTerminalIsConst;
        public FBool bTerminalIsWeakPointer;
        public FBool bTerminalIsUObjectWrapper;
        public UInt32 TerminalSubCategoryObject;

        public FEdGraphTerminalType Move(Transfer transfer)
        {
            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
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
            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
            {
                transfer.Move(ref bTerminalIsUObjectWrapper);
            }
            return this;
        }
    }
}
