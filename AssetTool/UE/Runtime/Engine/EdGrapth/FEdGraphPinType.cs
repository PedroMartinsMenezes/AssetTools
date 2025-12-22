using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferableStruct("EdGraphPinType")]
    public class FEdGraphPinType : ITransferable
    {
        public const string StructName = "EdGraphPinType";

        public FName PinCategory;
        public FString PinCategoryStr;
        public FName PinSubCategory;
        public FString PinSubCategoryStr;
        public FPackageIndex PinSubCategoryObject;
        public EPinContainerType? ContainerType;
        public FEdGraphTerminalType PinValueType;
        public FBool? bIsMap;
        public FBool? bIsSet;
        public FBool? bIsArray;
        public FBool bIsReferenceBool;
        public FBool bIsWeakPointerBool;
        public FSimpleMemberReference PinSubCategoryMemberReference;
        public FBool? bIsConstBool;
        public FBool? bIsUObjectWrapperBool;
        public FBool? bSerializeAsSinglePrecisionFloatBool;

        [Location("bool FEdGraphPinType::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_EDGRAPHPINTYPE_SERIALIZATION)
                return default;

            if (transfer.Supports.PinsStoreFName)
            {
                transfer.Move(ref PinCategory);
                transfer.Move(ref PinSubCategory);
            }
            else
            {
                transfer.Move(ref PinCategoryStr);
                transfer.Move(ref PinSubCategoryStr);
            }

            transfer.Move(ref PinSubCategoryObject);

            if (transfer.Supports.EdGraphPinContainerType)
            {
                transfer.MoveEnum(ref ContainerType);
                if (ContainerType == EPinContainerType.Map)
                {
                    transfer.Move(ref PinValueType);
                }
            }
            else
            {
                if (transfer.Supports.AdvancedContainerSupport)
                {
                    transfer.Move(ref bIsMap);
                    if (bIsMap is { })
                    {
                        transfer.Move(ref PinValueType);
                    }
                    transfer.Move(ref bIsSet);
                }
                transfer.Move(ref bIsArray);
            }

            transfer.Move(ref bIsReferenceBool);
            transfer.Move(ref bIsWeakPointerBool);

            if (transfer.Supports.VER_UE4_MEMBERREFERENCE_IN_PINTYPE)
            {
                transfer.Move(ref PinSubCategoryMemberReference);
            }
            if (transfer.Supports.VER_UE4_SERIALIZE_PINTYPE_CONST)
                transfer.Move(ref bIsConstBool);

            if (transfer.Supports.PinTypeIncludesUObjectWrapperFlag)
                transfer.Move(ref bIsUObjectWrapperBool);

            if (transfer.Supports.SerializeFloatPinDefaultValuesAsSinglePrecision)
                transfer.Move(ref bSerializeAsSinglePrecisionFloatBool);

            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            if (PinCategory is { })
                builder.Append($"PinCategory(`{PinCategory}`) ");
            if (PinCategoryStr is { })
                builder.Append($"PinCategoryStr(`{PinCategoryStr}`) ");
            if (PinSubCategory is { })
                builder.Append($"PinSubCategory(`{PinSubCategory}`) ");
            if (PinSubCategoryStr is { })
                builder.Append($"PinSubCategoryStr(`{PinSubCategoryStr}`) ");
            if (PinSubCategoryObject is { })
                builder.Append($"PinSubCategoryObject(`{PinSubCategoryObject}`) ");
            if (ContainerType is { })
                builder.Append($"ContainerType(`{ContainerType}`) ");
            if (PinValueType is { })
                builder.Append($"PinValueType((`{PinValueType}`)) ");
            if (bIsMap is { })
                builder.Append($"bIsMap(`{bIsMap}`) ");
            if (bIsSet is { })
                builder.Append($"bIsSet(`{bIsSet}`) ");
            if (bIsArray is { })
                builder.Append($"bIsArray(`{bIsArray}`) ");
            if (bIsReferenceBool is { })
                builder.Append($"bIsReferenceBool(`{bIsReferenceBool}`) ");
            if (bIsWeakPointerBool is { })
                builder.Append($"bIsWeakPointerBool(`{bIsWeakPointerBool}`) ");
            if (PinSubCategoryMemberReference is { })
                builder.Append($"PinSubCategoryMemberReference(`{PinSubCategoryMemberReference}`) ");
            if (bIsConstBool is { })
                builder.Append($"bIsConstBool(`{bIsConstBool}`) ");
            if (bIsUObjectWrapperBool is { })
                builder.Append($"bIsUObjectWrapperBool(`{bIsUObjectWrapperBool}`) ");
            if (bSerializeAsSinglePrecisionFloatBool is { })
                builder.Append($"bSerializeAsSinglePrecisionFloatBool(`{bSerializeAsSinglePrecisionFloatBool}`) ");
            return builder.ToString();
        }

        public static FEdGraphPinType FromString(string s)
        {
            FEdGraphPinType result = new();
            if (JsonSerializerExt.GetField(s, "PinCategory(`", "`)", out string pinCategory))
                result.PinCategory = new FName(pinCategory);
            if (JsonSerializerExt.GetField(s, "PinCategoryStr(`", "`)", out string pinCategoryStr))
                result.PinCategoryStr = new FString(pinCategoryStr);
            if (JsonSerializerExt.GetField(s, "PinSubCategory(`", "`)", out string pinSubCategory))
                result.PinSubCategory = new FName(pinSubCategory);
            if (JsonSerializerExt.GetField(s, "PinSubCategoryStr(`", "`)", out string pinSubCategoryStr))
                result.PinSubCategoryStr = new FString(pinSubCategoryStr);
            if (JsonSerializerExt.GetField(s, "PinSubCategoryObject(`", "`)", out string pinSubCategoryObject))
                result.PinSubCategoryObject = new FPackageIndex(pinSubCategoryObject);
            if (JsonSerializerExt.GetField(s, "ContainerType(`", "`)", out string containerType))
                result.ContainerType = Enum.Parse<EPinContainerType>(containerType);
            if (JsonSerializerExt.GetField(s, "PinValueType((`", "`))", out string pinValueType))
                result.PinValueType = FEdGraphTerminalType.FromString(pinValueType);
            if (JsonSerializerExt.GetField(s, "bIsMap(`", "`)", out string bIsMap))
                result.bIsMap = bool.Parse(bIsMap);
            if (JsonSerializerExt.GetField(s, "bIsSet(`", "`)", out string bIsSet))
                result.bIsSet = bool.Parse(bIsSet);
            if (JsonSerializerExt.GetField(s, "bIsArray(`", "`)", out string bIsArray))
                result.bIsArray = bool.Parse(bIsArray);
            if (JsonSerializerExt.GetField(s, "bIsReferenceBool(`", "`)", out string bIsReferenceBool))
                result.bIsReferenceBool = bool.Parse(bIsReferenceBool);
            if (JsonSerializerExt.GetField(s, "bIsWeakPointerBool(`", "`)", out string bIsWeakPointerBool))
                result.bIsWeakPointerBool = bool.Parse(bIsWeakPointerBool);
            if (JsonSerializerExt.GetField(s, "PinSubCategoryMemberReference(`", "`)", out string pinSubCategoryMemberReference))
                result.PinSubCategoryMemberReference = FSimpleMemberReference.FromString(pinSubCategoryMemberReference);
            if (JsonSerializerExt.GetField(s, "bIsConstBool(`", "`)", out string bIsConstBool))
                result.bIsConstBool = bool.Parse(bIsConstBool);
            if (JsonSerializerExt.GetField(s, "bIsUObjectWrapperBool(`", "`)", out string bIsUObjectWrapperBool))
                result.bIsUObjectWrapperBool = bool.Parse(bIsUObjectWrapperBool);
            if (JsonSerializerExt.GetField(s, "bSerializeAsSinglePrecisionFloatBool(`", "`)", out string bSerializeAsSinglePrecisionFloatBool))
                result.bSerializeAsSinglePrecisionFloatBool = bool.Parse(bSerializeAsSinglePrecisionFloatBool);
            return result;
        }
    }

    public class FEdGraphPinTypeJsonConverter : JsonConverter<FEdGraphPinType>
    {
        public override FEdGraphPinType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString();
            return FEdGraphPinType.FromString(text);
        }

        public override void Write(Utf8JsonWriter writer, FEdGraphPinType value, JsonSerializerOptions options)
        {
            string text = value.ToString();
            writer.WriteStringValue(text);
        }
    }
}
