using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UStruct::Serialize(FArchive& Ar)")]
    public class UStruct : UField
    {
        [JsonPropertyOrder(-8)] public FObjectPtr AccessTrackedObjectPtr = new();
        [JsonPropertyOrder(-8)] public UInt32 Children;
        [JsonPropertyOrder(-8)] public FStructScriptLoader ScriptLoadHelper = new();

        [JsonPropertyOrder(-8)][Sized] public List<FPackageIndex> ChildArray;
        [JsonPropertyOrder(-8)][Sized] public List<FField> ChildProperties;

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            AccessTrackedObjectPtr.Write(writer);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                writer.Write(Children);
            }
            else
            {
                writer.WriteValue(ref ChildArray, GetType().GetField("ChildArray"));
            }
            if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
            {
                WriteChildProperties(writer, ChildProperties);
            }
            ScriptLoadHelper.Construct(writer);
            ScriptLoadHelper.LoadStructWithScript(writer);
        }

        public new UStruct Read(BinaryReader reader)
        {
            base.Read(reader);
            AccessTrackedObjectPtr.Read(reader);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                reader.Read(ref Children);
            }
            else
            {
                reader.ReadValue(ref ChildArray, GetType().GetField("ChildArray"));
            }
            if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
            {
                ReadChildProperties(reader, ref ChildProperties);
            }
            ScriptLoadHelper.Construct(reader);
            ScriptLoadHelper.LoadStructWithScript(reader);
            return this;
        }

        private void ReadChildProperties(BinaryReader reader, ref List<FField> list)
        {
            list ??= new();
            int count = reader.ReadInt32();
            ///if (count > 0) Log.Info("ReadChildProperties");
            for (int i = 0; i < count; i++)
            {
                FName type = reader.ReadFName();
                if (type.ComparisonIndex.Value == 0)
                    throw new InvalidOperationException($"Invalid type at {reader.BaseStream.Position}");
                string name = type.Value;
                ///Log.Info($"  {name}");

                if (name == FStructProperty.TYPE_NAME) list.Add(new FStructProperty().Read(reader));
                else if (name == FEnumProperty.TYPE_NAME) list.Add(new FEnumProperty().Read(reader));
                else if (name == FObjectPropertyBase.TYPE_NAME) list.Add(new FObjectPropertyBase().Read(reader));
                else if (name == FIntProperty.TYPE_NAME) list.Add(new FIntProperty().Read(reader));
                else if (name == FFloatProperty.TYPE_NAME) list.Add(new FFloatProperty().Read(reader));
                else if (name == FDoubleProperty.TYPE_NAME) list.Add(new FDoubleProperty().Read(reader));
                else if (name == FBoolProperty.TYPE_NAME) list.Add(new FBoolProperty().Read(reader));
                else if (name == FInterfaceProperty.TYPE_NAME) list.Add(new FInterfaceProperty().Read(reader));
                else if (name == FStrProperty.TYPE_NAME) list.Add(new FStrProperty().Read(reader));
                else
                {
                    Log.Info($"[{reader.BaseStream.Position}] Invalid type: {name}");
                    list.Add(new FProperty().Read(reader));
                }
            }
        }

        private void WriteChildProperties(BinaryWriter writer, List<FField> list)
        {
            writer.Write(list.Count);
            foreach (var item in list)
            {
                writer.Write(new FName(item.TypeName));

                if (FStructProperty.TYPE_NAME == item.TypeName) ((FStructProperty)item).Write(writer);
                else if (FEnumProperty.TYPE_NAME == item.TypeName) ((FEnumProperty)item).Write(writer);
                else if (FObjectPropertyBase.TYPE_NAME == item.TypeName) ((FObjectPropertyBase)item).Write(writer);
                else if (FIntProperty.TYPE_NAME == item.TypeName) ((FIntProperty)item).Write(writer);
                else if (FFloatProperty.TYPE_NAME == item.TypeName) ((FFloatProperty)item).Write(writer);
                else if (FDoubleProperty.TYPE_NAME == item.TypeName) ((FDoubleProperty)item).Write(writer);
                else if (FBoolProperty.TYPE_NAME == item.TypeName) ((FBoolProperty)item).Write(writer);
                else if (FInterfaceProperty.TYPE_NAME == item.TypeName) ((FInterfaceProperty)item).Write(writer);
                else if (FStrProperty.TYPE_NAME == item.TypeName) ((FStrProperty)item).Write(writer);
                else
                {
                    Log.Info($"[{writer.BaseStream.Position}] Invalid type: {item.TypeName}");
                    ((FProperty)item).Write(writer);
                }
            }
        }
    }
}
