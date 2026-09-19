using System.Text;
using System.Text.Json;

namespace AssetTool
{
    public abstract class FPropertySerializerBase<T> where T : FProperty, new()
    {
        protected static T ReadKeyValue(string key, JsonElement root)
        {
            T value = new();

            value.NamePrivate = new FName(key[(key.IndexOf('\'') + 1)..^1]);

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

        protected static void WriteKeyValue(Utf8JsonWriter writer, JsonSerializerOptions options, T value, string name, Dictionary<string, object> inlineFields = null, Dictionary<string, object> fields = null)
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
                    if (pair.Value is { })
                    {
                        builder.Append($"{pair.Key}({pair.Value}) ");
                    }
                    else
                    {
                        builder.Append($"{pair.Key} ");
                    }
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

                writer.WriteStartObject();
                foreach (var pair in fields)
                {
                    if (pair.Value is FField field)
                    {
                        writer.WritePropertyName(pair.Key);
                        JsonSerializer.Serialize(writer, field, options);
                    }
                    else
                    {
                        writer.WritePropertyName(pair.Key);
                        JsonSerializer.Serialize(writer, pair.Value, options);
                    }
                }
                writer.WriteEndObject();
            }
        }
    }
}
