using System.Text;

namespace AssetTool
{
    public class FEdGraphTerminalType : ITransferable
    {
        public FName TerminalCategory;
        public FString TerminalCategoryStr;
        public FName TerminalSubCategory;
        public FString TerminalSubCategoryStr;
        public FBool? bTerminalIsConst;
        public FBool? bTerminalIsWeakPointer;
        public FBool? bTerminalIsUObjectWrapper;
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

            if (TerminalCategoryStr is { })
                builder.Append($"TerminalCategory(`{TerminalCategoryStr}`) ");

            if (TerminalSubCategoryStr is { })
                builder.Append($"TerminalSubCategory(`{TerminalSubCategoryStr}`) ");

            if (TerminalSubCategoryObject.Index != 0)
                builder.Append($"TerminalSubCategoryObject(`{TerminalSubCategoryObject.Index}`) ");

            if (bTerminalIsConst is { })
                builder.Append($"bTerminalIsConst(`{bTerminalIsConst}`) ");

            if (bTerminalIsWeakPointer is { })
                builder.Append($"bTerminalIsWeakPointer(`{bTerminalIsWeakPointer}`) ");

            if (bTerminalIsUObjectWrapper is { })
                builder.Append($"bTerminalIsUObjectWrapper(`{bTerminalIsUObjectWrapper}`) ");

            return builder.ToString();
        }

        public static FEdGraphTerminalType FromString(string s)
        {
            FEdGraphTerminalType result = Empty();

            if (JsonSerializerExt.GetField(s, "TerminalCategory(`", "`)", out string terminalCategory))
                result.TerminalCategoryStr = new FString(terminalCategory);

            if (JsonSerializerExt.GetField(s, "TerminalSubCategory(`", "`)", out string terminalSubCategory))
                result.TerminalSubCategoryStr = new FString(terminalSubCategory);

            if (JsonSerializerExt.GetField(s, "TerminalSubCategoryObject(`", "`)", out string terminalSubCategoryObject))
                result.TerminalSubCategoryObject = new FPackageIndex { Index = int.Parse(terminalSubCategoryObject) };

            result.bTerminalIsConst = s.Contains("bTerminalIsConst") ? true : null;
            result.bTerminalIsWeakPointer = s.Contains("bTerminalIsWeakPointer") ? true : null;
            result.bTerminalIsUObjectWrapper = s.Contains("bTerminalIsUObjectWrapper") ? true : null;

            return result;
        }

        private static FEdGraphTerminalType Empty()
        {
            return new FEdGraphTerminalType()
            {
                TerminalSubCategoryObject = new FPackageIndex()
            };
        }
    }
}