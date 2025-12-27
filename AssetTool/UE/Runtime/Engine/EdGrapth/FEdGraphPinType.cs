using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferableStruct("EdGraphPinType")]
    public class FEdGraphPinType : TransferableAutoCheck
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
        public override ITransferable MoveAutoCheck(Transfer transfer)
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
            PinSubCategoryObject = PinSubCategoryObject.Index != 0 ? PinSubCategoryObject : null;

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
                PinSubCategoryMemberReference = PinSubCategoryMemberReference.IsEmpty() ? null : PinSubCategoryMemberReference;
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
            builder.Append(PinSubCategoryStr is { } ? $"-{PinSubCategoryStr} " : " ");
            builder.AppendNonNull("obj(`{0}`) ", PinSubCategoryObject);
            builder.AppendNonNull("container(`{0}`) ", ContainerType);
            builder.AppendNonNull("value((`{0}`)) ", PinValueType);
            builder.AppendNonNull("ref(({0})) ", PinSubCategoryMemberReference);
            builder.AppendNonNull("isMap ", bIsMap);
            builder.AppendNonNull("isArray ", bIsArray);
            builder.AppendNonNull("isReference ", bIsReferenceBool);
            builder.AppendNonNull("isWeakPointer ", bIsWeakPointerBool);
            builder.AppendNonNull("isConst ", bIsConstBool);
            builder.AppendNonNull("isUObjectWrapperBool ", bIsUObjectWrapperBool);
            builder.AppendNonNull("isSingle ", bSerializeAsSinglePrecisionFloatBool);
            return builder.ToString(0, builder.Length - 1);
        }

        public static FEdGraphPinType FromString(string s)
        {
            FEdGraphPinType result = Empty();
            if (s.Length == 0)
                return result;

            int right = s.IndexOf(' ') < 0 ? s.Length : s.IndexOf(' ');
            string[] parts = s[0..right].Split('-');

            result.PinCategoryStr = new FString(parts[0]);
            result.PinSubCategoryStr = parts.Length > 1 ? new FString(parts[1]) : null;
            result.PinSubCategoryObject = s.GetNonNull("obj(`{0}`)", (x) => new FPackageIndex { Index = int.Parse(x) }, result.PinSubCategoryObject);
            result.ContainerType = s.GetNonNull("container(`{0}`)", (x) => Enum.Parse<EPinContainerType>(x));
            result.PinValueType = s.GetNonNull("value((`{0}`))", (x) => FEdGraphTerminalType.FromString(x), result.PinValueType);
            result.PinSubCategoryMemberReference = s.GetNonNull("ref((`{0}`))", (x) => FSimpleMemberReference.FromString(x), result.PinSubCategoryMemberReference);
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
                PinSubCategoryMemberReference = FSimpleMemberReference.Empty(),
                PinSubCategoryObject = new FPackageIndex(),
                PinValueType = FEdGraphTerminalType.Empty()
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
