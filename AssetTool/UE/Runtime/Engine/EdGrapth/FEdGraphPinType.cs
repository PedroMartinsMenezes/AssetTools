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
        public FBool? bIsReferenceBool;
        public FBool? bIsWeakPointerBool;
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
                PinCategory = PinCategoryStr is { } ? new FName(PinCategoryStr.Value) : new FName("None");
                transfer.Move(ref PinCategory);
                PinCategoryStr = PinCategory.Value != "None" ? new(PinCategory.ToString()) : null;

                PinSubCategory = PinSubCategoryStr is { } ? new FName(PinSubCategoryStr.Value) : new FName("None");
                transfer.Move(ref PinSubCategory);
                PinSubCategoryStr = PinSubCategory.Value != "None" ? new(PinSubCategory.ToString()) : null;
            }
            else
            {
                PinCategoryStr = PinCategoryStr is { } ? PinCategoryStr : new FString("");
                transfer.Move(ref PinCategoryStr);
                PinCategoryStr = PinCategoryStr.Length > 0 ? PinCategoryStr : null;

                PinSubCategoryStr = PinSubCategoryStr is { } ? PinSubCategoryStr : new FString("");
                transfer.Move(ref PinSubCategoryStr);
                PinSubCategoryStr = PinSubCategoryStr.Length > 0 ? PinSubCategoryStr : null;
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
            builder.Append($"{PinCategoryStr}");

            if (PinSubCategoryStr is { })
                builder.Append($"-{PinSubCategoryStr} ");
            else
                builder.Append(" ");

            if (PinSubCategoryObject.Index != 0)
                builder.Append($"obj(`{PinSubCategoryObject}`) ");
            if (ContainerType is { })
                builder.Append($"container(`{ContainerType}`) ");
            if (PinValueType is { })
                builder.Append($"value((`{PinValueType}`)) ");
            if (PinSubCategoryMemberReference is { } && !PinSubCategoryMemberReference.IsEmpty())
                builder.Append($"ref(({PinSubCategoryMemberReference})) ");

            if (bIsMap is { })
                builder.Append("isMap ");
            if (bIsSet is { })
                builder.Append("isSet ");
            if (bIsArray is { })
                builder.Append("isArray ");
            if (bIsReferenceBool is { })
                builder.Append("isReference ");
            if (bIsWeakPointerBool is { })
                builder.Append("isWeakPointer ");
            if (bIsConstBool is { })
                builder.Append("isConst ");
            if (bIsUObjectWrapperBool is { })
                builder.Append("isUObjectWrapperBool ");
            if (bSerializeAsSinglePrecisionFloatBool is { })
                builder.Append("isSingle ");

            return builder.ToString(0, builder.Length - 1);
        }

        public static FEdGraphPinType FromString(string s)
        {
            FEdGraphPinType result = Empty();
            if (s.Length == 0)
            {
                return result;
            }

            int right = s.IndexOf(' ') < 0 ? s.Length : s.IndexOf(' ');
            string[] parts = s[0..right].Split('-');

            result.PinCategoryStr = new FString(parts[0]);
            result.PinSubCategoryStr = parts.Length > 1 ? new FString(parts[1]) : null;

            if (JsonSerializerExt.GetField(s, "obj(`", "`)", out string pinSubCategoryObject))
                result.PinSubCategoryObject = new FPackageIndex(pinSubCategoryObject);

            if (JsonSerializerExt.GetField(s, "container(`", "`)", out string containerType))
                result.ContainerType = Enum.Parse<EPinContainerType>(containerType);

            if (JsonSerializerExt.GetField(s, "value((`", "`))", out string pinValueType))
                result.PinValueType = FEdGraphTerminalType.FromString(pinValueType);

            if (JsonSerializerExt.GetField(s, "ref((`", "`))", out string pinSubCategoryMemberReference))
                result.PinSubCategoryMemberReference = FSimpleMemberReference.FromString(pinSubCategoryMemberReference);

            result.bIsMap = s.Contains("isMap") ? true : null;
            result.bIsSet = s.Contains("isSet") ? true : null;
            result.bIsArray = s.Contains("isArray") ? true : null;
            result.bIsReferenceBool = s.Contains("isReference") ? true : null;
            result.bIsWeakPointerBool = s.Contains("isWeakPointer") ? true : null;
            result.bIsConstBool = s.Contains("isConst") ? true : null;
            result.bIsUObjectWrapperBool = s.Contains("isUObjectWrapperBool") ? true : null;
            result.bSerializeAsSinglePrecisionFloatBool = s.Contains("isSingle") ? true : null;

            return result;
        }

        public static FEdGraphPinType Empty()
        {
            return new FEdGraphPinType
            {
                PinSubCategoryMemberReference = FSimpleMemberReference.FromString(""),
                PinSubCategoryObject = new FPackageIndex(),
                PinValueType = FEdGraphTerminalType.FromString("")
            };
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
