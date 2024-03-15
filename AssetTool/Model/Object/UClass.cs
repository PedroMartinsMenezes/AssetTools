namespace AssetTool
{
    [Location("void UClass::Serialize( FArchive& Ar )")]
    public class UClass : UStruct
    {
        public TMap1<FName, UInt32> FuncMap = new();
        public UInt32 ClassFlags;
        public UInt32 ClassWithin;
        public FName ClassConfigName = new();
        public UInt32 ClassGeneratedBy;
        [Sized] public List<FImplementedInterface> SerializedInterfaces;
        public FBool bDeprecatedForceScriptOrder;
        public FName Dummy = new();
        public FBool bCookedAsBool = new();
        public UInt32 PerspectiveNewCDO;
    }

    public static class UClassExt
    {
        public static void Write(this BinaryWriter writer, UClass item)
        {
            writer.Write((UStruct)item);
            writer.WriteValue(item.FuncMap, item.GetType().GetField("FuncMap"));

            writer.Write(item.ClassFlags);
            writer.Write(item.ClassWithin);
            writer.Write(item.ClassConfigName);
            writer.Write(item.ClassGeneratedBy);
            writer.WriteValue(item.SerializedInterfaces, item.GetType().GetField("SerializedInterfaces"));
            writer.Write(item.bDeprecatedForceScriptOrder);
            writer.Write(item.Dummy);
            writer.Write(item.bCookedAsBool);
            writer.Write(item.PerspectiveNewCDO);
        }

        public static UClass Read(this BinaryReader reader, UClass item)
        {
            reader.Read((UStruct)item);
            reader.ReadValue(item.FuncMap, item.GetType().GetField("FuncMap"));
            reader.Read(ref item.ClassFlags);
            reader.Read(ref item.ClassWithin);
            reader.Read(ref item.ClassConfigName);

            long InterfacesStart = 0;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                InterfacesStart = reader.BaseStream.Position;
                Int32 NumInterfaces = reader.ReadInt32();
                reader.BaseStream.Position = InterfacesStart + 4 + NumInterfaces * 12;
            }

            reader.Read(ref item.ClassGeneratedBy);

            long CurrentOffset = reader.BaseStream.Position;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                reader.BaseStream.Position = InterfacesStart;
            }

            reader.ReadValue(ref item.SerializedInterfaces, item.GetType().GetField("SerializedInterfaces"));

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                reader.BaseStream.Position = CurrentOffset;
            }

            reader.Read(ref item.bDeprecatedForceScriptOrder);
            reader.Read(ref item.Dummy);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_COOKED_TO_UCLASS))
            {
                reader.Read(ref item.bCookedAsBool);
            }

            reader.Read(ref item.PerspectiveNewCDO);

            return item;
        }
    }
}
