using System.Text;

namespace AssetTool
{
    public class FEdGraphTerminalType : ITransferable
    {
        public FName TerminalCategory;
        public FString TerminalCategoryStr;
        public FName TerminalSubCategory;
        public FString TerminalSubCategoryStr;
        public bool? bTerminalIsConst;
        public bool? bTerminalIsWeakPointer;
        public bool? bTerminalIsUObjectWrapper;
        public FPackageIndex TerminalSubCategoryObject;

        [Location("FArchive& operator<<(FArchive& Ar, FEdGraphTerminalType& T)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.PinsStoreFName)
            {
                TerminalCategory = TerminalCategoryStr is { } ? new FName(TerminalCategoryStr.Value) : new FName("None");
                transfer.Move(ref TerminalCategory);
                TerminalCategoryStr = TerminalCategory.Value != "None" ? new(TerminalCategory.ToString()) : null;

                TerminalSubCategory = TerminalSubCategoryStr is { } ? new FName(TerminalSubCategoryStr.Value) : new FName("None");
                transfer.Move(ref TerminalSubCategory);
                TerminalSubCategoryStr = TerminalSubCategory.Value != "None" ? new(TerminalSubCategory.ToString()) : null;
            }
            else
            {
                transfer.Move(ref TerminalCategoryStr);
                transfer.Move(ref TerminalSubCategoryStr);
            }

            transfer.Move(ref TerminalSubCategoryObject);
            TerminalSubCategoryObject = TerminalSubCategoryObject.Index != 0 ? TerminalSubCategoryObject : null;

            transfer.Move(ref bTerminalIsConst);
            transfer.Move(ref bTerminalIsWeakPointer);
            if (transfer.Supports.PinTypeIncludesUObjectWrapperFlag)
            {
                transfer.Move(ref bTerminalIsUObjectWrapper);
            }
            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.AppendNonNull("TerminalCategory(`{0}`) ", TerminalCategoryStr);
            builder.AppendNonNull("TerminalSubCategory(`{0}`) ", TerminalSubCategoryStr);
            builder.AppendNonNull("TerminalSubCategoryObject(`{0}`) ", TerminalSubCategoryObject);
            builder.AppendNonNull("bTerminalIsConst(`{0}`) ", bTerminalIsConst);
            builder.AppendNonNull("bTerminalIsWeakPointer(`{0}`) ", bTerminalIsWeakPointer);
            builder.AppendNonNull("bTerminalIsUObjectWrapper(`{0}`) ", bTerminalIsUObjectWrapper);
            return builder.ToString();
        }

        public static FEdGraphTerminalType FromString(string s)
        {
            FEdGraphTerminalType result = Empty();
            result.TerminalCategoryStr = s.GetNonNull("TerminalCategory(`{0}`)", (x) => new FString(x));
            result.TerminalSubCategoryStr = s.GetNonNull("TerminalSubCategory(`{0}`)", (x) => new FString(x));
            result.TerminalSubCategoryObject = s.GetNonNull("TerminalSubCategoryObject(`{0}`)", (x) => new FPackageIndex { Index = int.Parse(x) }, result.TerminalSubCategoryObject);
            result.bTerminalIsConst = s.Contains("bTerminalIsConst") ? true : null;
            result.bTerminalIsWeakPointer = s.Contains("bTerminalIsWeakPointer") ? true : null;
            result.bTerminalIsUObjectWrapper = s.Contains("bTerminalIsUObjectWrapper") ? true : null;
            return result;
        }

        public static FEdGraphTerminalType Empty()
        {
            return new FEdGraphTerminalType()
            {
                TerminalSubCategoryObject = new FPackageIndex()
            };
        }
    }
}