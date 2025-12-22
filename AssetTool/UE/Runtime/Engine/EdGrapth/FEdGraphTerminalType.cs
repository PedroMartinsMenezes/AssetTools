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

        public override string ToString()
        {
            StringBuilder builder = new();
            if (TerminalCategory is { })
                builder.Append($"TerminalCategory(`{TerminalCategory}`) ");
            if (TerminalCategoryStr is { })
                builder.Append($"TerminalCategoryStr(`{TerminalCategoryStr}`) ");
            if (TerminalSubCategory is { })
                builder.Append($"TerminalSubCategory(`{TerminalSubCategory}`) ");
            if (TerminalSubCategoryStr is { })
                builder.Append($"TerminalSubCategoryStr(`{TerminalSubCategoryStr}`) ");
            if (bTerminalIsConst is { })
                builder.Append($"bTerminalIsConst(`{bTerminalIsConst}`) ");
            if (bTerminalIsWeakPointer is { })
                builder.Append($"bTerminalIsWeakPointer(`{bTerminalIsWeakPointer}`) ");
            if (bTerminalIsUObjectWrapper is { })
                builder.Append($"bTerminalIsUObjectWrapper(`{bTerminalIsUObjectWrapper}`) ");
            if (TerminalSubCategoryObject is { })
                builder.Append($"TerminalSubCategoryObject(`{TerminalSubCategoryObject.Index}`) ");
            return builder.ToString();
        }

        public static FEdGraphTerminalType FromString(string s)
        {
            FEdGraphTerminalType result = new() { bTerminalIsConst = false, bTerminalIsWeakPointer = false, bTerminalIsUObjectWrapper = false };
            if (JsonSerializerExt.GetField(s, "TerminalCategory(`", "`)", out string terminalCategory))
                result.TerminalCategory = new FName(terminalCategory);
            if (JsonSerializerExt.GetField(s, "TerminalCategoryStr(`", "`)", out string terminalCategoryStr))
                result.TerminalCategoryStr = new FString(terminalCategoryStr);
            if (JsonSerializerExt.GetField(s, "TerminalSubCategory(`", "`)", out string terminalSubCategory))
                result.TerminalSubCategory = new FName(terminalSubCategory);
            if (JsonSerializerExt.GetField(s, "TerminalSubCategoryStr(`", "`)", out string terminalSubCategoryStr))
                result.TerminalSubCategoryStr = new FString(terminalSubCategoryStr);
            if (JsonSerializerExt.GetField(s, "bTerminalIsConst(`", "`)", out string bTerminalIsConst))
                result.bTerminalIsConst = bool.Parse(bTerminalIsConst);
            if (JsonSerializerExt.GetField(s, "bTerminalIsWeakPointer(`", "`)", out string bTerminalIsWeakPointer))
                result.bTerminalIsWeakPointer = bool.Parse(bTerminalIsWeakPointer);
            if (JsonSerializerExt.GetField(s, "bTerminalIsUObjectWrapper(`", "`)", out string bTerminalIsUObjectWrapper))
                result.bTerminalIsUObjectWrapper = bool.Parse(bTerminalIsUObjectWrapper);
            if (JsonSerializerExt.GetField(s, "TerminalSubCategoryObject(`", "`)", out string terminalSubCategoryObject))
                result.TerminalSubCategoryObject = new FPackageIndex { Index = int.Parse(terminalSubCategoryObject) };
            return result;
        }
    }
}
