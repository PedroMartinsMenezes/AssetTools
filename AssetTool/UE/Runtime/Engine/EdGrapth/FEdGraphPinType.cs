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
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return;

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                writer.Write(item.PinCategory);
                writer.Write(item.PinSubCategory);
            }

            writer.Write(item.PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
                writer.Write(item.ContainerType);

            writer.Write(item.bIsReferenceBool);
            writer.Write(item.bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                writer.Write(item.PinSubCategoryMemberReference);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                writer.Write(item.bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                writer.Write(item.bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                writer.Write(item.bSerializeAsSinglePrecisionFloatBool);
        }

        public static FEdGraphPinType Read(this BinaryReader reader, ref FEdGraphPinType item)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION))
                return null;
            item ??= new();

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName))
            {
                reader.Read(ref item.PinCategory);
                reader.Read(ref item.PinSubCategory);
            }
            else
            {
                item.PinCategory = new FName(reader.ReadFString().Value);
                item.PinSubCategory = new FName(reader.ReadFString().Value);
            }

            reader.Read(ref item.PinSubCategoryObject);

            if (Supports.CustomVer(FFrameworkObjectVersion.Enums.EdGraphPinContainerType))
            {
                reader.Read(ref item.ContainerType);
                if ((EPinContainerType)item.ContainerType == EPinContainerType.Map)
                {
                    ///Ar << PinValueType;
                    throw new NotImplementedException();
                }
            }
            else
            {
                if (Supports.CustomVer(FBlueprintsObjectVersion.Enums.AdvancedContainerSupport))
                {
                    ///Ar << bIsMap;
                    ///if (bIsMap)
                    ///{
                    ///    Ar << PinValueType; //Tipo FEdGraphTerminalType
                    ///}
                    ///Ar << bIsSet;
                    throw new NotImplementedException();
                }
                ///Ar << bIsArray;
                throw new NotImplementedException();
            }

            reader.Read(ref item.bIsReferenceBool);
            reader.Read(ref item.bIsWeakPointerBool);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MEMBERREFERENCE_IN_PINTYPE))
                reader.Read(ref item.PinSubCategoryMemberReference);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_PINTYPE_CONST))
                reader.Read(ref item.bIsConstBool);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.PinTypeIncludesUObjectWrapperFlag))
                reader.Read(ref item.bIsUObjectWrapperBool);

            if (Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.SerializeFloatPinDefaultValuesAsSinglePrecision))
                reader.Read(ref item.bSerializeAsSinglePrecisionFloatBool);

            return item;
        }
    }
}
