using System.Text.Json;

namespace AssetTool
{
    public abstract class FPropertySerializerBase<T> where T : FProperty
    {
        protected static void ReadBaseProperties(JsonElement root, T value)
        {
            if (root.TryGetProperty("ArrayDim", out var arrayDim))
                value.ArrayDim = arrayDim.GetInt32();

            if (root.TryGetProperty("PropertyFlags", out var propertyFlags))
                Enum.TryParse(propertyFlags.GetString(), out value.PropertyFlags);

            if (root.TryGetProperty("RepIndex", out var repIndex))
                value.RepIndex = repIndex.GetUInt16();

            if (root.TryGetProperty("RepNotifyFunc", out var repNotifyFunc))
                value.RepNotifyFunc = new FName(repNotifyFunc.GetString());

            if (root.TryGetProperty("BlueprintReplicationCondition", out var condition))
                value.BlueprintReplicationCondition = condition.GetByte();

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
        }

        protected static void WriteBaseProperties(Utf8JsonWriter writer, T value)
        {
            if (value.ArrayDim != 1)
                writer.WriteNumber("ArrayDim", value.ArrayDim);

            if (value.PropertyFlags != EPropertyFlags.CPF_None)
                writer.WriteString("PropertyFlags", value.PropertyFlags.ToString());

            if (value.RepIndex != 0)
                writer.WriteNumber("RepIndex", value.RepIndex);

            if (value.RepNotifyFunc.Value != "None")
                writer.WriteString("RepNotifyFunc", value.RepNotifyFunc.ToString());

            if (value.BlueprintReplicationCondition != 0)
                writer.WriteNumber("BlueprintReplicationCondition", value.BlueprintReplicationCondition);

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
        }
    }
}
