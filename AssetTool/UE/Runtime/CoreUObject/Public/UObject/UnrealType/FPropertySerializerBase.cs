using System.Text;
using System.Text.Json;

namespace AssetTool
{
    public abstract class FPropertySerializerBase<T> where T : FProperty, new()
    {
        protected T ReadBaseProperties(JsonElement root)
        {
            T value = new()
            {
                ArrayDim = 1,
                PropertyFlags = EPropertyFlags.CPF_None,
                RepIndex = 0,
                RepNotifyFunc = new FName("None"),
                BlueprintReplicationCondition = 0,
                FlagsPrivate = EObjectFlags.RF_Public,
                HasMetaData = false
            };

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

            if (root.TryGetProperty("NamePrivate", out var namePrivate))
                value.NamePrivate = new FName(namePrivate.GetString());

            if (root.TryGetProperty("FlagsPrivate", out var flagsPrivate))
                Enum.TryParse(flagsPrivate.GetString(), out value.FlagsPrivate);

            if (root.TryGetProperty("MetaDataMap", out var metaDataMap))
            {
                value.HasMetaData = true;
                foreach (var property in metaDataMap.EnumerateObject())
                {
                    value.MetaDataMap.Add(new FName(property.Name), new FString(property.Value.GetString() ?? string.Empty));
                }
            }

            return value;
        }

        protected static void WriteBaseProperties(Utf8JsonWriter writer, T value)
        {
            writer.WriteString("__type", value.GetType().Name);

            writer.WriteString("NamePrivate", value.NamePrivate.ToString());

            if (value.PropertyFlags != EPropertyFlags.CPF_None)
                writer.WriteString("PropertyFlags", value.PropertyFlags.ToString());

            if (value.FlagsPrivate != EObjectFlags.RF_Public)
                writer.WriteString("FlagsPrivate", value.FlagsPrivate.ToString());

            if (value.ArrayDim != 1)
                writer.WriteNumber("ArrayDim", value.ArrayDim);

            if (value.RepIndex != 0)
                writer.WriteNumber("RepIndex", value.RepIndex);

            if (value.RepNotifyFunc.Value != "None")
                writer.WriteString("RepNotifyFunc", value.RepNotifyFunc.ToString());

            if (value.BlueprintReplicationCondition != 0)
                writer.WriteNumber("BlueprintReplicationCondition", value.BlueprintReplicationCondition);

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

        protected T ReadKeyValue(string key, JsonElement root)
        {
            T value = new();

            value.NamePrivate = new FName(key.Split("'")[1]);

            value.PropertyFlags = key.GetNonNull("PropertyFlags({0})", x => Enum.Parse<EPropertyFlags>(x), EPropertyFlags.CPF_None);
            value.FlagsPrivate = key.GetNonNull("FlagsPrivate({0})", x => Enum.Parse<EObjectFlags>(x), EObjectFlags.RF_Public);
            value.ArrayDim = key.GetNonNull("ArrayDim({0})", x => int.Parse(x), 1);
            value.RepIndex = key.GetNonNull("RepIndex({0})", x => ushort.Parse(x), (ushort)0);
            value.RepNotifyFunc = key.GetNonNull("RepNotifyFunc({0})", x => new FName(x), new FName("None"));
            value.BlueprintReplicationCondition = key.GetNonNull("BlueprintReplicationCondition({0})", x => byte.Parse(x), (byte)0);

            if (root.ValueKind == JsonValueKind.Object)
            {
                if (root.TryGetProperty("MetaDataMap", out var metaDataMap))
                {
                    value.HasMetaData = true;
                    foreach (var property in metaDataMap.EnumerateObject())
                    {
                        value.MetaDataMap.Add(new FName(property.Name), new FString(property.Value.GetString() ?? string.Empty));
                    }
                }
            }

            return value;
        }

        protected void WriteKeyValue(Utf8JsonWriter writer, JsonSerializerOptions options, T value, string name, Dictionary<string, object> inlineFields = null, Dictionary<string, object> fields = null)
        {
            StringBuilder builder = new();

            builder.Append($"{name} ");

            //Base members
            if (value.PropertyFlags != EPropertyFlags.CPF_None) builder.Append($"PropertyFlags({value.PropertyFlags}) ");
            if (value.FlagsPrivate != EObjectFlags.RF_Public) builder.Append($"FlagsPrivate({value.FlagsPrivate}) ");
            if (value.ArrayDim != 1) builder.Append($"ArrayDim({value.ArrayDim}) ");
            if (value.RepIndex != 0) builder.Append($"RepIndex({value.RepIndex}) ");
            if (value.RepNotifyFunc.Value != "None") builder.Append($"RepNotifyFunc({value.RepNotifyFunc}) ");
            if (value.BlueprintReplicationCondition != 0) builder.Append($"BlueprintReplicationCondition({value.BlueprintReplicationCondition}) ");

            //Derived members inlined
            if (inlineFields is { } && inlineFields.Count > 0)
            {
                foreach (var pair in inlineFields)
                {
                    builder.Append($"{pair.Key}({pair.Value}) ");
                }
            }

            //NamePrivate
            builder.Append($"'{value.NamePrivate}'");

            //Derived members body
            if (value.HasMetaData)
            {
                fields ??= new();
                fields["MetaDataMap"] = value.MetaDataMap;
            }

            string key = builder.ToString();

            if (fields is null)
            {
                writer.WriteString(key, string.Empty);
            }
            else
            {
                writer.WritePropertyName(key);
                JsonSerializer.Serialize(writer, fields, options);
            }
        }
    }
}
