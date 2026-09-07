using System.Text.Json;

namespace AssetTool
{
    public class FIntProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "IntProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public static int MoveValue(Transfer transfer, int value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public static class FIntPropertySerializer
    {
        public static FIntProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = new FIntProperty
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

            if (root.TryGetProperty("ArrayDim", out var arrayDim))
                value.ArrayDim = arrayDim.GetInt32();

            if (root.TryGetProperty("ElementSize", out var elementSize))
                value.ElementSize = elementSize.GetInt32();

            if (root.TryGetProperty("PropertyFlags", out var propertyFlags))
                Enum.TryParse(propertyFlags.GetString(), out value.PropertyFlags);

            if (root.TryGetProperty("RepIndex", out var repIndex))
                value.RepIndex = repIndex.GetUInt16();

            if (root.TryGetProperty("RepNotifyFunc", out var repNotifyFunc))
                value.RepNotifyFunc = new FName(repNotifyFunc.GetString());

            if (root.TryGetProperty("BlueprintReplicationCondition", out var condition))
                value.BlueprintReplicationCondition = condition.GetByte();

            if (root.TryGetProperty("NamePrivate", out var namePrivate))
                value.NamePrivate = new FName(namePrivate.GetString());

            if (root.TryGetProperty("FlagsPrivate", out var flagsPrivate))
                Enum.TryParse(flagsPrivate.GetString(), out value.FlagsPrivate);

            if (root.TryGetProperty("HasMetaData", out var hasMetaData))
                value.HasMetaData = hasMetaData.GetBoolean();

            if (value.HasMetaData && root.TryGetProperty("MetaDataMap", out var metaDataMap))
            {
                foreach (var property in metaDataMap.EnumerateObject())
                {
                    value.MetaDataMap.Add(new FName(property.Name), new FString(property.Value.GetString() ?? string.Empty));
                }
            }

            return value;
        }

        public static void Write(Utf8JsonWriter writer, FIntProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("__type", "FIntProperty");

            if (value.ArrayDim != 1)
                writer.WriteNumber("ArrayDim", value.ArrayDim);

            if (value.ElementSize != 4)
                writer.WriteNumber("ElementSize", value.ElementSize);

            if (value.PropertyFlags != EPropertyFlags.CPF_None)
                writer.WriteString("PropertyFlags", value.PropertyFlags.ToString());

            if (value.RepIndex != 0)
                writer.WriteNumber("RepIndex", value.RepIndex);

            if (value.RepNotifyFunc.Value != "None")
                writer.WriteString("RepNotifyFunc", value.RepNotifyFunc.ToString());

            if (value.BlueprintReplicationCondition != 0)
                writer.WriteNumber("BlueprintReplicationCondition", value.BlueprintReplicationCondition);

            writer.WriteString("NamePrivate", value.NamePrivate.ToString());

            if (value.FlagsPrivate != EObjectFlags.RF_Public)
                writer.WriteString("FlagsPrivate", value.FlagsPrivate.ToString());

            if (value.HasMetaData)
                writer.WriteBoolean("HasMetaData", value.HasMetaData);

            if (value.HasMetaData)
            {
                writer.WritePropertyName("MetaDataMap");
                writer.WriteStartObject();
                foreach (var kvp in value.MetaDataMap)
                {
                    writer.WriteString(kvp.Key.ToString(), kvp.Value.ToString());
                }
                writer.WriteEndObject();
            }

            writer.WriteEndObject();
        }
    }
}
