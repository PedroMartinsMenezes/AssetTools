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

        public new UStruct Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private UStruct Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            AccessTrackedObjectPtr.Move(transfer);
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
            return this;
        }

        private UStruct Read(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;
            AccessTrackedObjectPtr.Move(transfer);
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
            var transfer = GlobalObjects.Transfer;
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

                if (name == FStructProperty.TYPE_NAME) list.Add(new FStructProperty().Move(transfer));
                else if (name == FEnumProperty.TYPE_NAME) list.Add(new FEnumProperty().Move(transfer));
                else if (name == FObjectPropertyBase.TYPE_NAME) list.Add(new FObjectPropertyBase().Move(transfer));
                else if (name == FIntProperty.TYPE_NAME) list.Add(new FIntProperty().Move(transfer));
                else if (name == FFloatProperty.TYPE_NAME) list.Add(new FFloatProperty().Move(transfer));
                else if (name == FDoubleProperty.TYPE_NAME) list.Add(new FDoubleProperty().Move(transfer));
                else if (name == FBoolProperty.TYPE_NAME) list.Add(new FBoolProperty().Move(transfer));
                else if (name == FInterfaceProperty.TYPE_NAME) list.Add(new FInterfaceProperty().Move(transfer));
                else if (name == FStrProperty.TYPE_NAME) list.Add(new FStrProperty().Move(transfer));
                else
                {
                    Log.Info($"[{reader.BaseStream.Position}] Invalid type: {name}");
                    list.Add(new FProperty().Move(transfer));
                }
            }
        }

        private void WriteChildProperties(BinaryWriter writer, List<FField> list)
        {
            var transfer = GlobalObjects.Transfer;
            writer.Write(list.Count);
            foreach (var item in list)
            {
                writer.Write(new FName(item.TypeName));

                if (FStructProperty.TYPE_NAME == item.TypeName) ((FStructProperty)item).Move(transfer);
                else if (FEnumProperty.TYPE_NAME == item.TypeName) ((FEnumProperty)item).Move(transfer);
                else if (FObjectPropertyBase.TYPE_NAME == item.TypeName) ((FObjectPropertyBase)item).Move(transfer);
                else if (FIntProperty.TYPE_NAME == item.TypeName) ((FIntProperty)item).Move(transfer);
                else if (FFloatProperty.TYPE_NAME == item.TypeName) ((FFloatProperty)item).Move(transfer);
                else if (FDoubleProperty.TYPE_NAME == item.TypeName) ((FDoubleProperty)item).Move(transfer);
                else if (FBoolProperty.TYPE_NAME == item.TypeName) ((FBoolProperty)item).Move(transfer);
                else if (FInterfaceProperty.TYPE_NAME == item.TypeName) ((FInterfaceProperty)item).Move(transfer);
                else if (FStrProperty.TYPE_NAME == item.TypeName) ((FStrProperty)item).Move(transfer);
                else
                {
                    Log.Info($"[{writer.BaseStream.Position}] Invalid type: {item.TypeName}");
                    ((FProperty)item).Move(transfer);
                }
            }
        }
    }
}
