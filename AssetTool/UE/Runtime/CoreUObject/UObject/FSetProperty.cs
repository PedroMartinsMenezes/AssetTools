using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName}<{PropertyTypeName}> {NamePrivate.ToString()}")]
    public class FSetProperty : FProperty
    {
        public new const string TYPE_NAME = "SetProperty";
        public override string TypeName => TYPE_NAME;

        #region Serialize
        public FName PropertyTypeName;
        public FField Field;
        #endregion

        #region SerializeItem
        public Int32 NumElementsToRemove;
        public Int32 Num;
        public List<object> Values;
        public List<object> ValuesToRemove;
        #endregion

        #region Serialize
        [Location("void FSetProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref Field);
            return this;
        }
        #endregion

        #region SerializeItem
        [Location("void FSetProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults)")]
        public FField MoveValue(Transfer transfer, string name, string valueType, string keyType, int indent)
        {
            transfer.Move(ref NumElementsToRemove);

            for (int i = 0; i < NumElementsToRemove; i++)
            {
                transfer.Resize(ref ValuesToRemove, NumElementsToRemove, true);
                AddItems(transfer, ValuesToRemove, NumElementsToRemove, name, valueType, keyType, indent);
            }

            transfer.Move(ref Num);
            transfer.Resize(ref Values, Num, true);
            AddItems(transfer, Values, Num, name, valueType, keyType, indent);
            return this;
        }

        [Location("void FWeakObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults )")]
        private void AddItems(Transfer transfer, List<object> values, int count, string name, string valueType, string keyType, int indent)
        {
            for (var i = 0; i < count; i++)
            {
                if (Transfers.ContainsKey(keyType))
                    values[i] = Transfers[keyType](transfer, values[i]);
                else if (TransfersForSetProperty.ContainsKey(name))
                    values[i] = TransfersForSetProperty[name](transfer, values[i]);
                else if (keyType == FStructProperty.TYPE_NAME)
                    values[i] = transfer.MoveTags(values[i].ToObject<Dictionary<string, object>>(transfer), indent);
                else
                    throw new InvalidOperationException($"Invalid Type : {keyType}");
            }
        }
        #endregion

        static FSetProperty()
        {
            #region OK
            Transfers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>(transfer)));
            Transfers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            Transfers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>(transfer)));
            Transfers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>(transfer)));
            Transfers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>(transfer)));
            Transfers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>(transfer)));
            Transfers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>(transfer)));
            Transfers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>(transfer)));
            Transfers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            Transfers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>(transfer)));
            Transfers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>(transfer)));
            Transfers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>(transfer)));
            Transfers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>(transfer)));
            Transfers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FEnumProperty.TYPE_NAME, (transfer, value) => FEnumProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            Transfers.Add(FClassProperty.TYPE_NAME, (transfer, value) => FClassProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FSoftObjectProperty.TYPE_NAME, (transfer, value) => FSoftObjectProperty.MoveValue(transfer, value.ToObject<FSoftObjectPtr>(transfer)));
            #endregion

            #region Values found on Folder: Plugins
            TransfersForSetProperty.Add("PropertiesIDsOverridden", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            TransfersForSetProperty.Add("ExposedEntities", (transfer, value) => value.ToObject<FRCEntityWrapper>(transfer).Move(transfer));
            #endregion
        }

        public static Dictionary<string, Func<Transfer, object, object>> Transfers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> TransfersForSetProperty { get; } = new();
    }
}
