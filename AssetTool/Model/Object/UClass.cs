namespace AssetTool
{
    [Location("void UClass::Serialize( FArchive& Ar )")]
    public class UClass : UStruct
    {
        public TMap1<FName, UInt32> FuncMap = new();
        public UInt32 ClassFlags;
        public UInt32 ClassWithin;
        public FName ClassConfigName = new();
        public Int32 NumInterfaces;
        public UInt32 ClassGeneratedBy;
        [Sized] public List<FImplementedInterface> SerializedInterfaces;
        public FBool bDeprecatedForceScriptOrder;
        public FName Dummy = new();
        public FBool bCookedAsBool = new();
        public UInt32 PerspectiveNewCDO;

        public new UClass Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.ReadValue(FuncMap, GetType().GetField("FuncMap"));
            reader.Read(ref ClassFlags);
            reader.Read(ref ClassWithin);
            reader.Read(ref ClassConfigName);

            long InterfacesStart = 0;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                InterfacesStart = reader.BaseStream.Position;
                NumInterfaces = reader.ReadInt32();
                reader.BaseStream.Position = InterfacesStart + 4 + NumInterfaces * 12;
            }

            reader.Read(ref ClassGeneratedBy);

            long CurrentOffset = reader.BaseStream.Position;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                reader.BaseStream.Position = InterfacesStart;
            }

            reader.ReadValue(ref SerializedInterfaces, GetType().GetField("SerializedInterfaces"));

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                reader.BaseStream.Position = CurrentOffset;
            }

            reader.Read(ref bDeprecatedForceScriptOrder);
            reader.Read(ref Dummy);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_COOKED_TO_UCLASS))
            {
                reader.Read(ref bCookedAsBool);
            }

            reader.Read(ref PerspectiveNewCDO);

            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.WriteValue(FuncMap, GetType().GetField("FuncMap"));

            writer.Write(ClassFlags);
            writer.Write(ClassWithin);
            writer.Write(ClassConfigName);

            long InterfacesStart = 0;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                InterfacesStart = writer.BaseStream.Position;
                writer.Write(NumInterfaces);
                writer.BaseStream.Position = InterfacesStart + 4 + NumInterfaces * 12;
            }

            writer.Write(ClassGeneratedBy);

            long CurrentOffset = writer.BaseStream.Position;
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                writer.BaseStream.Position = InterfacesStart;
            }

            writer.WriteValue(SerializedInterfaces, GetType().GetField("SerializedInterfaces"));

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_UCLASS_SERIALIZE_INTERFACES_AFTER_LINKING))
            {
                writer.BaseStream.Position = CurrentOffset;
            }

            writer.Write(bDeprecatedForceScriptOrder);
            writer.Write(Dummy);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_COOKED_TO_UCLASS))
            {
                writer.Write(bCookedAsBool);
            }

            writer.Write(PerspectiveNewCDO);
        }
    }
}
