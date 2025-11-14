using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FSimpleMemberReference : ITransferable
    {
        public UInt32 MemberParent;
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
    }

    public class FSimpleMemberReferenceJsonConverter : JsonConverter<FSimpleMemberReference>
    {
        public override FSimpleMemberReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                return new FSimpleMemberReference { MemberName = new FName("None") };
            }
            else
            {
                reader.Read(); // Move to first property
                FSimpleMemberReference memberReference = new FSimpleMemberReference();
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    string propertyName = reader.GetString();
                    reader.Read(); // Move to value
                    switch (propertyName)
                    {
                        case "MemberParent":
                            memberReference.MemberParent = reader.GetUInt32();
                            break;
                        case "MemberName":
                            memberReference.MemberName = new FName(reader.GetString());
                            break;
                        case "MemberGuid":
                            memberReference.MemberGuid = new FGuid(reader.GetString());
                            break;
                    }
                    reader.Read(); // Move to next property or end object
                }
                return memberReference;
            }
        }

        public override void Write(Utf8JsonWriter writer, FSimpleMemberReference value, JsonSerializerOptions options)
        {
            if (value.IsEmpty())
            {
                writer.WriteStringValue("null");
            }
            else
            {
                writer.WriteStartObject();
                writer.WriteNumber("MemberParent", value.MemberParent);
                writer.WriteString("MemberName", value.MemberName.ToString());
                writer.WriteString("MemberGuid", value.MemberGuid.ToString());
                writer.WriteEndObject();
            }
        }
    }
}
