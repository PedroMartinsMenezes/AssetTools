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

            AccessTrackedObjectPtr.Move(transfer);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                transfer.Move(ref Children);
            }
            else
            {
                ChildArray ??= new();
                ChildArray.Resize(transfer);
                ChildArray.ForEach(x => x.Move(transfer));
            }
            if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
            {
                ChildProperties ??= new();
                MoveChildProperties(transfer, ref ChildProperties);
            }
            ScriptLoadHelper.Construct(transfer);
            ScriptLoadHelper.LoadStructWithScript(transfer);
            return this;
        }

        //private UStruct Write(BinaryWriter writer)
        //{
        //    var transfer = GlobalObjects.Transfer;
        //    AccessTrackedObjectPtr.Move(transfer);
        //    if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
        //    {
        //        transfer.Move(ref Children);
        //    }
        //    else
        //    {
        //        ChildArray.Resize(transfer);
        //        ChildArray.ForEach(x => x.Move(transfer));
        //    }
        //    if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
        //    {
        //        WriteChildProperties(writer, ChildProperties);
        //    }
        //    ScriptLoadHelper.Construct(writer);
        //    ScriptLoadHelper.LoadStructWithScript(writer);
        //    return this;
        //}

        //private UStruct Move(BinaryReader reader)
        //{
        //    var transfer = GlobalObjects.Transfer;
        //    AccessTrackedObjectPtr.Move(transfer);
        //    if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
        //    {
        //        transfer.Move(ref Children);
        //    }
        //    else
        //    {
        //        ChildArray.Resize(transfer);
        //        ChildArray.ForEach(x => x.Move(transfer));
        //    }
        //    if (Supports.CustomVer(FCoreObjectVersion.Enums.FProperties))
        //    {
        //        MoveChildProperties(transfer, ref ChildProperties);
        //    }
        //    ScriptLoadHelper.Construct(reader);
        //    ScriptLoadHelper.LoadStructWithScript(reader);
        //    return this;
        //}

        private void MoveChildProperties(Transfer transfer, ref List<FField> list)
        {
            list.Resize(transfer, true);
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                FName typeName = item is null ? new() : new FName(item.TypeName);
                transfer.Move(ref typeName);

                if (typeName.ComparisonIndex.Value == 0)
                    throw new InvalidOperationException($"Invalid type at {transfer.Position}");

                string name = typeName.Value;

                if (name == FStructProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FStructProperty().Move(transfer);
                else if (name == FEnumProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FEnumProperty().Move(transfer);
                else if (name == FObjectPropertyBase.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FObjectPropertyBase().Move(transfer);
                else if (name == FIntProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FIntProperty().Move(transfer);
                else if (name == FFloatProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FFloatProperty().Move(transfer);
                else if (name == FDoubleProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FDoubleProperty().Move(transfer);
                else if (name == FBoolProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FBoolProperty().Move(transfer);
                else if (name == FInterfaceProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FInterfaceProperty().Move(transfer);
                else if (name == FStrProperty.TYPE_NAME) list[i] = item?.Move(transfer) ?? new FStrProperty().Move(transfer);
                else
                {
                    Log.Info($"[{transfer.Position}] Invalid type: {name}");
                    list[i] = (item ?? new FProperty()).Move(transfer);
                }
            }
        }

        //private void WriteChildProperties(BinaryWriter writer, List<FField> list)
        //{
        //    var transfer = GlobalObjects.Transfer;
        //    writer.Write(list.Count);
        //    foreach (var item in list)
        //    {
        //        writer.Write(new FName(item.TypeName));

        //        if (FStructProperty.TYPE_NAME == item.TypeName) ((FStructProperty)item).Move(transfer);
        //        else if (FEnumProperty.TYPE_NAME == item.TypeName) ((FEnumProperty)item).Move(transfer);
        //        else if (FObjectPropertyBase.TYPE_NAME == item.TypeName) ((FObjectPropertyBase)item).Move(transfer);
        //        else if (FIntProperty.TYPE_NAME == item.TypeName) ((FIntProperty)item).Move(transfer);
        //        else if (FFloatProperty.TYPE_NAME == item.TypeName) ((FFloatProperty)item).Move(transfer);
        //        else if (FDoubleProperty.TYPE_NAME == item.TypeName) ((FDoubleProperty)item).Move(transfer);
        //        else if (FBoolProperty.TYPE_NAME == item.TypeName) ((FBoolProperty)item).Move(transfer);
        //        else if (FInterfaceProperty.TYPE_NAME == item.TypeName) ((FInterfaceProperty)item).Move(transfer);
        //        else if (FStrProperty.TYPE_NAME == item.TypeName) ((FStrProperty)item).Move(transfer);
        //        else
        //        {
        //            Log.Info($"[{writer.BaseStream.Position}] Invalid type: {item.TypeName}");
        //            ((FProperty)item).Move(transfer);
        //        }
        //    }
        //}
    }
}
