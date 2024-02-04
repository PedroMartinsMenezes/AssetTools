namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;
        public long NextOffset => Offset + Size;
        public long Size;
        public string Type;
        public UObject Obj;

        public T Get<T>() where T : new()
        {
            T obj = new T();
            Obj = obj as UObject;
            return obj;
        }
    }

    public static class AssetObjectExt
    {
        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static void ReadAssetObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (type == Consts.MetaData) reader.Read(item.Get<UMetadata>());
            else if (type == Consts.UserDefinedStruct) reader.Read(item.Get<UUserDefinedStruct>());
            else if (type == Consts.UserDefinedStructEditorData) reader.Read(item.Get<UUserDefinedStructEditorData>());
            else if (type == Consts.ArrowComponent) reader.Read(item.Get<UArrowComponent>());
            else if (type == Consts.Blueprint) reader.Read(item.Get<UBlueprint>());
            else if (type == Consts.BlueprintGeneratedClass) reader.Read(item.Get<UBlueprintGeneratedClass>());
            else if (type.StartsWith("Default__")) reader.Read(item.Get<UObject>());
            else if (type.StartsWith("CameraComponent")) reader.Read(item.Get<UCameraComponent>());
            else if (type.StartsWith("CapsuleComponent")) reader.Read(item.Get<UCapsuleComponent>());
            else if (type.StartsWith("CharacterMovementComponent")) reader.Read(item.Get<UCharacterMovementComponent>());
            else if (type.StartsWith("EdGraph")) reader.Read(item.Get<UEdGraph>());
            else reader.Read(item.Get<UObject>());
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                writer.Write((UMetadata)item.Obj);
            else if (type == Consts.UserDefinedStruct)
                writer.Write((UUserDefinedStruct)item.Obj);
            else if (type == Consts.UserDefinedStructEditorData)
                writer.Write((UUserDefinedStructEditorData)item.Obj);
            else if (type == Consts.ArrowComponent)
                writer.Write((UArrowComponent)item.Obj);
            else if (type == Consts.Blueprint)
                writer.Write((UBlueprint)item.Obj);
            else if (type == Consts.BlueprintGeneratedClass)
                writer.Write(item.Get<UBlueprintGeneratedClass>());
        }
    }
}
