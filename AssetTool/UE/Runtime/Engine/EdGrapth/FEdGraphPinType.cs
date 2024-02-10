namespace AssetTool
{
    [Location("bool FEdGraphPinType::Serialize(FArchive& Ar)")]
    public class FEdGraphPinType
    {
        public FName PinCategory;
        public FName PinSubCategory;
        public UInt32 PinSubCategoryObject;
        public byte ContainerType;
        public FBool bIsReferenceBool;
        public FBool bIsWeakPointerBool;

        public FSimpleMemberReference PinSubCategoryMemberReference;

        public FBool bIsConstBool;
        public FBool bIsUObjectWrapperBool;
        public FBool bSerializeAsSinglePrecisionFloatBool;
    }

    public static class FEdGraphPinTypeExt
    {
        public static void Write(this BinaryWriter writer, FEdGraphPinType item)
        {

        }

        public static FEdGraphPinType Read(this BinaryReader reader, ref FEdGraphPinType item)
        {
            item ??= new();

            reader.Read(ref item.PinCategory);
            reader.Read(ref item.PinSubCategory);
            reader.Read(ref item.PinSubCategoryObject);
            reader.Read(ref item.ContainerType);
            reader.Read(ref item.bIsReferenceBool);
            reader.Read(ref item.bIsWeakPointerBool);

            reader.Read(ref item.PinSubCategoryMemberReference);

            reader.Read(ref item.bIsConstBool);
            reader.Read(ref item.bIsUObjectWrapperBool);
            reader.Read(ref item.bSerializeAsSinglePrecisionFloatBool);

            return item;
        }
    }
}
