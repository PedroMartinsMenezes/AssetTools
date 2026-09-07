using System.Text.Json;

namespace AssetTool
{
    public class FDoubleProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "DoubleProperty";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static double MoveValue(Transfer transfer, double value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FDoublePropertySerializer : FPropertySerializerBase<FDoubleProperty>
    {
        public static FDoubleProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = new FDoubleProperty
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
            #endregion

            return value;
        }

        public static void Write(Utf8JsonWriter writer, FDoubleProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteBaseProperties(writer, value);

            #region Derived Properties
            writer.WriteString("__type", "FDoubleProperty");

            if (value.ElementSize != 8)
                writer.WriteNumber("ElementSize", value.ElementSize);

            writer.WriteString("NamePrivate", value.NamePrivate.ToString());

            #endregion

            writer.WriteEndObject();
        }
    }
}
