using System.Text.Json;

namespace AssetTool
{
    public class FObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "ObjectProperty";
        public override string TypeName => TYPE_NAME;

        public FObjectPtr Value;

        [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        public static Int32 MoveValue(Transfer transfer, Int32 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FObjectPropertySerializer : FPropertySerializerBase<FObjectProperty>
    {
        public static FObjectProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = new FObjectProperty
            {
                ArrayDim = 1,
                ElementSize = 8,
                PropertyFlags = EPropertyFlags.CPF_None,
                RepIndex = 0,
                RepNotifyFunc = new FName("None"),
                BlueprintReplicationCondition = 0,
                FlagsPrivate = EObjectFlags.RF_Public,
                HasMetaData = false
            };

            ReadBaseProperties(root, value);

            #region Derived Properties
            if (root.TryGetProperty("ElementSize", out var elementSize))
                value.ElementSize = elementSize.GetInt32();

            if (root.TryGetProperty("NamePrivate", out var namePrivate))
                value.NamePrivate = new FName(namePrivate.GetString());

            if (root.TryGetProperty("Value", out var valueProperty))
                value.Value = FObjectPtr.FromString(valueProperty.GetString());
            #endregion

            return value;
        }

        public static void Write(Utf8JsonWriter writer, FObjectProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteBaseProperties(writer, value);

            #region Derived Properties
            writer.WriteString("__type", "FObjectProperty");

            if (value.ElementSize != 8)
                writer.WriteNumber("ElementSize", value.ElementSize);

            writer.WriteString("NamePrivate", value.NamePrivate.ToString());

            writer.WriteString("Value", value.Value.ToString());
            #endregion

            writer.WriteEndObject();
        }
    }
}
