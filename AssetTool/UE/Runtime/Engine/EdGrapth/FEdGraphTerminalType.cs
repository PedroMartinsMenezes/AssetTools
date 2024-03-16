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

        public FEdGraphTerminalType Read(BinaryReader reader)
        {
            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                reader.Read(ref TerminalCategory);
                reader.Read(ref TerminalSubCategory);
            }
            else
            {
                reader.Read(ref TerminalCategoryStr);
                reader.Read(ref TerminalSubCategoryStr);
            }
            reader.Read(ref bTerminalIsConst);
            reader.Read(ref bTerminalIsWeakPointer);
            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
            {
                reader.Read(ref bTerminalIsUObjectWrapper);
            }
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                writer.Write(TerminalCategory);
                writer.Write(TerminalSubCategory);
            }
            else
            {
                writer.Write(TerminalCategoryStr);
                writer.Write(TerminalSubCategoryStr);
            }
            writer.Write(bTerminalIsConst);
            writer.Write(bTerminalIsWeakPointer);
            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
            {
                writer.Write(bTerminalIsUObjectWrapper);
            }
        }
    }
}
