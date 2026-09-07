using System.Text.Json;

namespace AssetTool
{
    public class FFloatProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static float MoveValue(Transfer transfer, float value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FFloatPropertySerializer : FPropertySerializerBase<FFloatProperty>
    {
        public static FFloatProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = new FFloatProperty
            {
                ArrayDim = 1,
                ElementSize = 4,
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

        public static void Write(Utf8JsonWriter writer, FFloatProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteBaseProperties(writer, value);

            #region Derived Properties
            writer.WriteString("__type", "FFloatProperty");

            if (value.ElementSize != 4)
                writer.WriteNumber("ElementSize", value.ElementSize);

            writer.WriteString("NamePrivate", value.NamePrivate.ToString());
            #endregion

            writer.WriteEndObject();
        }
    }
}
