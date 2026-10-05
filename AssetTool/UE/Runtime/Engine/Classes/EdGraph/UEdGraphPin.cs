using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region FSimpleMemberReference
    public class FSimpleMemberReference : ITransferable
    {
        public Int32 MemberParent;
        public FName MemberName;
        public FGuid MemberGuid;

        [Location("operator<<(FArchive& Ar, FSimpleMemberReference& Data)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MemberParent);
            transfer.Move(ref MemberName);
            transfer.Move(ref MemberGuid);
            return this;
        }

        public bool IsEmpty() => MemberParent == 0 && !MemberName.IsFilled() && MemberGuid.Value == Guid.Empty;

        public override string ToString()
        {
            return !IsEmpty() ? $"`{MemberParent}` `{MemberGuid}` `{MemberName}`" : string.Empty;
        }

        public static FSimpleMemberReference FromString(string s)
        {
            FSimpleMemberReference result = Empty();
            string[] parts = s.Split("` `");
            if (parts.Length == 3)
            {
                result.MemberParent = Int32.Parse(parts[0]);
                result.MemberGuid = new FGuid(parts[1]);
                result.MemberName = new FName(parts[2]);
            }
            return result;
        }

        public static FSimpleMemberReference Empty()
        {
            FSimpleMemberReference result = new();
            result.MemberName = new FName("None");
            return result;
        }
    }

    public class FSimpleMemberReferenceJsonConverter : JsonConverter<FSimpleMemberReference>
    {
        public override FSimpleMemberReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var result = new FSimpleMemberReference { MemberName = new FName("None") };

            string text = reader.GetString();
            if (text == "null")
                return result;

            result.MemberParent = text.GetNonNull("MemberParent({0})", x => int.Parse(x));
            result.MemberName = text.GetNonNull("MemberName({0}) MemberGuid(", x => new FName(x));
            result.MemberGuid = text.GetNonNull("MemberGuid({0})", x => new FGuid(x));


            return result;
        }

        public override void Write(Utf8JsonWriter writer, FSimpleMemberReference value, JsonSerializerOptions options)
        {
            if (value.IsEmpty())
                writer.WriteStringValue("null");
            else
                writer.WriteStringValue($"MemberParent({value.MemberParent}) MemberName({value.MemberName}) MemberGuid({value.MemberGuid})");
        }
    }
    #endregion

    #region FEdGraphPinType
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
        public bool? bIsMap;
        public bool? bIsSet;
        public bool? bIsArray;
        public bool? bIsReferenceBool;
        public bool? bIsWeakPointerBool;
        public FSimpleMemberReference PinSubCategoryMemberReference;
        public bool? bIsConstBool;
        public bool? bIsUObjectWrapperBool;
        public bool? bSerializeAsSinglePrecisionFloatBool;

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

            PinSubCategoryObject ??= new();
            transfer.Move(ref PinSubCategoryObject);
            PinSubCategoryObject = PinSubCategoryObject.Index != 0 ? PinSubCategoryObject : null;

            if (transfer.Supports.EdGraphPinContainerType)
            {
                transfer.MoveEnum(ref ContainerType);
                ContainerType = ContainerType == EPinContainerType.None ? null : ContainerType;
                if (ContainerType == EPinContainerType.Map)
                {
                    PinValueType ??= FEdGraphTerminalType.Empty();
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
                        PinValueType ??= FEdGraphTerminalType.Empty();
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
                PinSubCategoryMemberReference ??= FSimpleMemberReference.Empty();
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
            builder.AppendNonNull("value(({0})) ", PinValueType);
            builder.AppendNonNull("ref({0}) ", PinSubCategoryMemberReference);
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
            FEdGraphPinType result = new();
            if (s.Length == 0)
                return result;

            int right = s.IndexOf(' ') < 0 ? s.Length : s.IndexOf(' ');
            string[] parts = s[0..right].Split('-');

            result.PinCategoryStr = new FString(parts[0]);
            result.PinSubCategoryStr = parts.Length > 1 ? new FString(parts[1]) : null;
            result.PinSubCategoryObject = s.GetNonNull("obj(`{0}`)", (x) => new FPackageIndex { Index = int.Parse(x) });
            result.ContainerType = s.GetNonNull("container(`{0}`)", (x) => Enum.Parse<EPinContainerType>(x), (EPinContainerType?)null);
            result.PinValueType = s.GetNonNull("value(({0}))", (x) => FEdGraphTerminalType.FromString(x));
            result.PinSubCategoryMemberReference = s.GetNonNull("ref(`{0}`)", (x) => FSimpleMemberReference.FromString(x));
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
    #endregion

    #region UEdGraphPin
    [DebuggerDisplay("[{ResolveType}] {PinGuid} {PinName}")]
    public class UEdGraphPin
    {
        public const string TypeName = "EdGraphPin";

        [JsonIgnore] public UEdGraphNode Owner;
        [JsonIgnore] public EPinResolveType ResolveType;
        [JsonIgnore] public bool SerializeCalled;

        #region SerializePin
        public bool? bNullPtr;
        public TRef LocalOwningNode;
        public FGuid? PinGuid;
        #endregion

        #region Part 2
        public TRef OwningNode;
        public FGuid? PinId;
        public FName PinName;
        public FString PinNameStr;
        public FText PinFriendlyName;
        public Int32? SourceIndex;
        public FString PinToolTip;
        public EEdGraphPinDirection Direction;

        public FEdGraphPinType PinType;

        public FString DefaultValue;
        public FString AutogeneratedDefaultValue;
        public FObjectPtr DefaultObject;
        public FText DefaultTextValue;

        public NonOwningNodePin LinkedTo;
        public NonOwningNodePin SubPins;

        public ParentPinWrapper ParentPin;

        public UEdGraphPin ReferencePassThroughConnection;

        public FGuid? PersistentGuid;
        public UInt32? BitField;
        #endregion

        [Location("void UEdGraphPin::SerializePinArray(FArchive& Ar, TArray<UEdGraphPin*>& ArrayRef, UEdGraphPin* RequestingPin, EPinResolveType ResolveType)")]
        public static void SerializePinArray(Transfer transfer, ref List<UEdGraphPin> ArrayRef, EPinResolveType ResolveType, UEdGraphNode node)
        {
            transfer.Resize(ref ArrayRef, true);
            for (int i = 0; i < ArrayRef.Count; i++)
            {
                bool bNullPtr = ArrayRef[i]?.bNullPtr ?? new bool();
                transfer.Move(ref bNullPtr);
                if (!bNullPtr)
                {
                    ArrayRef[i] ??= new();
                    ArrayRef[i].Owner = node;
                    ArrayRef[i].ResolveType = ResolveType;
                    SerializePin(transfer, ArrayRef[i]);
                }
            }
        }

        [Location("bool UEdGraphPin::SerializePin(FArchive& Ar, UEdGraphPin*& PinRef, int32 ArrayIdx, UEdGraphPin* RequestingPin, EPinResolveType ResolveType, TArray<UEdGraphPin*>& OldPins)")]
        public static void SerializePin(Transfer transfer, UEdGraphPin PinRef)
        {
            transfer.Move(ref PinRef.LocalOwningNode);
            transfer.Move(ref PinRef.PinGuid);
            if (PinRef.ResolveType == EPinResolveType.OwningNode)
            {
                PinRef.Serialize(transfer);
            }
        }

        [Location("bool UEdGraphPin::Serialize(FArchive& Ar)")]
        public UEdGraphPin Serialize(Transfer transfer)
        {
            SerializeCalled = true;

            transfer.Move(ref OwningNode);
            transfer.Move(ref PinId);

            if (transfer.Supports.PinsStoreFName)
            {
                PinName = PinNameStr is { } ? new FName(PinNameStr.Value) : new FName("None");
                transfer.Move(ref PinName);
                PinNameStr = PinName.Value != "None" ? new(PinName.ToString()) : null;
            }
            else
            {
                transfer.Move(ref PinNameStr);
            }

            PinFriendlyName = PinFriendlyName is null ? new FText() { HistoryType = (ETextHistoryType)(-1) } : PinFriendlyName;
            if (!transfer.GlobalObjects.IsFilterEditorOnly())
                transfer.Move(ref PinFriendlyName);
            PinFriendlyName = PinFriendlyName.IsNull ? null : PinFriendlyName;

            if (transfer.Supports.EdGraphPinSourceIndex)
                transfer.Move(ref SourceIndex);

            transfer.Move(ref PinToolTip);
            transfer.MoveEnum(ref Direction);

            transfer.Move(ref PinType);

            transfer.Move(ref DefaultValue);
            transfer.Move(ref AutogeneratedDefaultValue);

            DefaultObject ??= new();
            transfer.Move(ref DefaultObject);

            DefaultTextValue = DefaultTextValue is null ? new FText() { HistoryType = (ETextHistoryType)(-1) } : DefaultTextValue;
            transfer.Move(ref DefaultTextValue);
            DefaultTextValue = DefaultTextValue.IsNull ? null : DefaultTextValue;

            LinkedTo ??= new();
            UEdGraphPin.SerializePinArray(transfer, ref LinkedTo.List, EPinResolveType.LinkedTo, Owner);
            LinkedTo = LinkedTo.List.Count == 0 ? null : LinkedTo;

            SubPins ??= new();
            UEdGraphPin.SerializePinArray(transfer, ref SubPins.List, EPinResolveType.SubPins, Owner);
            SubPins = SubPins.List.Count == 0 ? null : SubPins;

            bool ParentPinIsNull = ParentPin is null;
            transfer.Move(ref ParentPinIsNull);
            if (!ParentPinIsNull)
            {
                ParentPin ??= new();
                ParentPin.ParentPin.ResolveType = EPinResolveType.ParentPin;
                SerializePin(transfer, ParentPin.ParentPin);
            }

            bool ReferencePassThroughConnectionIsNull = ReferencePassThroughConnection is null;
            transfer.Move(ref ReferencePassThroughConnectionIsNull);
            if (!ReferencePassThroughConnectionIsNull)
            {
                ReferencePassThroughConnection ??= new();
                ReferencePassThroughConnection.ResolveType = EPinResolveType.ReferencePassThroughConnection;
                SerializePin(transfer, ReferencePassThroughConnection);
            }

            if (!transfer.GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref PersistentGuid);
                transfer.Move(ref BitField);
            }

            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            if (ResolveType != EPinResolveType.OwningNode)
            {
                builder.Append($"{LocalOwningNode} {PinGuid}");
            }
            else
            {
                builder.Append(Direction == EEdGraphPinDirection.EGPD_Input ? "input-pin " : "output-pin ");
                builder.AppendNonNull("Type«`{0}`» ", PinType);
                builder.AppendNonNull("Name«`{0}`» ", PinNameStr);
                builder.AppendNonNull("PinFriendlyName«`{0}`» ", PinFriendlyName?.ToSimpleString());
                builder.AppendNonNull("Id«`{0} {1}`» ", LocalOwningNode, PinGuid);
                builder.AppendNonNull("LinkedTo«`{0}`» ", LinkedTo);
                builder.AppendNonNull("SubPins«`{0}`» ", SubPins);
                builder.AppendNonNull("ToolTip«`{0}`» ", PinToolTip);
                builder.AppendNonNull("DefaultValue«`{0}`» ", DefaultValue);
                builder.AppendNonNull("AutogeneratedDefaultValue«`{0}`» ", AutogeneratedDefaultValue);
                builder.AppendNonNull("BitField«`{0}`» ", BitField);
                builder.AppendNonNull("DefaultObject«`{0}`» ", DefaultObject);
                builder.AppendNonNull("SourceIndex«`{0}`» ", SourceIndex);
                builder.AppendNonNull("ParentPin«`{0}`» ", ParentPin);
                builder.AppendNonNull("ReferencePassThroughConnection«`{0}`» ", ReferencePassThroughConnection);
                builder.AppendNonNull("DefaultTextValue«`{0}`» ", DefaultTextValue?.ToSimpleString());
                builder.AppendNonNull("PersistentGuid«`{0}`» ", PersistentGuid);
            }
            return builder.ToString();
        }

        public static UEdGraphPin FromString(string str)
        {
            UEdGraphPin result = new();
            result.Direction = str[0..str.IndexOf(' ')] == "input-pin" ? EEdGraphPinDirection.EGPD_Input : EEdGraphPinDirection.EGPD_Output;
            result.PinType = str.GetNonNull("Type«`{0}`»", x => FEdGraphPinType.FromString(x));
            if (result.PinType is { })
            {
                result.PinNameStr = str.GetNonNull(" Name«`{0}`»", x => new FString(x));
                result.PinName = str.GetNonNull(" Name«`{0}`»", x => new FName(x));
                result.PinFriendlyName = str.GetNonNull(" PinFriendlyName«`{0}`»", x => FText.FromSimpleString(x));
                result.LocalOwningNode = result.OwningNode = str.GetNonNull(" Id«`{0}`»", x => TRef.FromString(x[0..x.IndexOf(' ')]));
                result.PinGuid = result.PinId = str.GetNonNull(" Id«`{0}`»", x => new FGuid(x[x.IndexOf(' ')..]), (FGuid?)null);
                result.LinkedTo = str.GetNonNull(" LinkedTo«`{0}`»", x => NonOwningNodePin.FromString(x, EPinResolveType.LinkedTo));
                result.SubPins = str.GetNonNull(" SubPins«`{0}`»", x => NonOwningNodePin.FromString(x, EPinResolveType.SubPins));
                result.PinToolTip = str.GetNonNull(" ToolTip«`{0}`»", x => new FString(x));
                result.DefaultValue = str.GetNonNull(" DefaultValue«`{0}`»", x => new FString(x));
                result.AutogeneratedDefaultValue = str.GetNonNull(" AutogeneratedDefaultValue«`{0}`»", x => new FString(x));
                result.BitField = str.GetNonNull(" BitField«`{0}`»", x => uint.Parse(x), (uint?)null);
                result.DefaultObject = str.GetNonNull(" DefaultObject«`{0}`»", x => FObjectPtr.FromString(x));
                result.SourceIndex = str.GetNonNull(" SourceIndex«`{0}`»", x => int.Parse(x), (int?)null);
                result.ParentPin = str.GetNonNull(" ParentPin«`{0}`»", x => ParentPinWrapper.FromString(x));
                result.ReferencePassThroughConnection = str.GetNonNull(" ReferencePassThroughConnection«`{0}`»", x => UEdGraphPin.FromString(x));
                result.DefaultTextValue = str.GetNonNull(" DefaultTextValue«`{0}`»", x => FText.FromSimpleString(x));
                result.PersistentGuid = str.GetNonNull(" PersistentGuid«`{0}`»", x => new FGuid(x), (FGuid?)null);
            }
            else
            {
                result.LocalOwningNode = result.OwningNode = TRef.FromString(str.Split(' ')[0]);
                result.PinGuid = result.PinId = new FGuid(str.Split(' ')[1]);
            }
            return result;
        }
    }

    public class UEdGraphPinJsonConverter : JsonConverter<UEdGraphPin>
    {
        public override UEdGraphPin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return UEdGraphPin.FromString(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, UEdGraphPin value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
    #endregion

    #region LinkedTo JsonConverter
    public class NonOwningNodePin
    {
        public List<UEdGraphPin> List = [];

        public override string ToString() => string.Join(" | ", List.Select(x => $"{(x).LocalOwningNode} {(x).PinGuid}"));

        public static NonOwningNodePin FromString(string str, EPinResolveType resolveType)
        {
            NonOwningNodePin result = new();
            string[] parts = str.Split(" | ");
            result.List = [];
            foreach (var part in parts)
            {
                var item = new UEdGraphPin
                {
                    ResolveType = resolveType,
                    LocalOwningNode = TRef.FromString(part[0..part.IndexOf(' ')]),
                    PinGuid = new FGuid(part.Split(' ')[1])
                };
                result.List.Add(item);
            }
            return result;
        }
    }

    public class LinkedToWrapperJsonConverter : JsonConverter<NonOwningNodePin>
    {
        public override NonOwningNodePin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString();
            if (text.Length == 0)
            {
                return new();
            }
            NonOwningNodePin list = new();
            var lines = text.Split(" | ");
            foreach (var line in lines)
            {
                var v = line.Split(' ');
                var item = new UEdGraphPin
                {
                    LocalOwningNode = new TRef { ExportIndex = Int32.Parse(v[0]) },
                    PinGuid = new FGuid(v[1])
                };
                list.List.Add(item);
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, NonOwningNodePin value, JsonSerializerOptions options)
        {
            var lines = string.Join(" | ", value.List.Select(x => $"{(x).LocalOwningNode.ExportIndex} {(x).PinGuid}"));
            if (lines.Length == 0)
                writer.WriteNullValue();
            else
                writer.WriteStringValue(lines);
        }
    }
    #endregion

    #region ParentPin JsonConverter
    public class ParentPinWrapper
    {
        public UEdGraphPin ParentPin = new();

        public override string ToString() => $"{ParentPin.LocalOwningNode} {ParentPin.PinGuid}";

        public static ParentPinWrapper FromString(string str) => new() { ParentPin = new() { LocalOwningNode = TRef.FromString(str.Split(' ')[0]), PinGuid = new FGuid(str.Split(' ')[1]) } };
    }

    public class ParentPinWrapperJsonConverter : JsonConverter<ParentPinWrapper>
    {
        public override ParentPinWrapper Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ReadOnlySpan<char> span = reader.GetString().AsSpan();

            Int32 exportIndex = Int32.Parse(span.Slice(0, span.IndexOf(' ')));
            string guid = span.Slice(span.IndexOf(' ') + 1).ToString();

            return new() { ParentPin = new() { LocalOwningNode = new() { ExportIndex = exportIndex }, PinGuid = new FGuid(guid) } };
        }

        public override void Write(Utf8JsonWriter writer, ParentPinWrapper value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.ParentPin.LocalOwningNode.ExportIndex} {value.ParentPin.PinGuid}");
        }
    }
    #endregion



    #region UEdGraphPin_Deprecated
    [JsonAsset("EdGraphPin")]
    public class UEdGraphPin_Deprecated : UObject
    {
    }
    #endregion

    public enum EPinResolveType : UInt32
    {
        OwningNode,
        LinkedTo,
        SubPins,
        ParentPin,
        ReferencePassThroughConnection
    }
}
