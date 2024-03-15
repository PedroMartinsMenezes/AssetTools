namespace AssetTool
{
    [Location("UFunction::Serialize( FArchive& Ar )")]
    public class UFunction : UStruct
    {
        public const string TypeName = "Function";

        public UInt32 FunctionFlags;
        public Int16 RepOffset;
        public UInt32 EventGraphFunction;
        public Int32 EventGraphCallOffset;
    }

    public static class UFunctionExt
    {
        public static void Write(this BinaryWriter writer, UFunction item)
        {
            writer.Write((UStruct)item);

            writer.Write(item.FunctionFlags);

            if ((item.FunctionFlags & (uint)EFunctionFlags.FUNC_Net) == (uint)EFunctionFlags.FUNC_Net)
            {
                writer.Write(item.RepOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION))
            {
                writer.Write(item.EventGraphFunction);
                writer.Write(item.EventGraphCallOffset);
            }
            ///if ((Ar.GetPortFlags() & PPF_Duplicate) != 0)
            ///{
            ///    Ar << NumParms;
            ///    Ar << ParmsSize;
            ///    Ar << ReturnValueOffset;
            ///    Ar << FirstPropertyToInit;
            ///}
        }

        public static UFunction Read(this BinaryReader reader, UFunction item)
        {
            reader.Read((UStruct)item);

            reader.Read(ref item.FunctionFlags);

            if ((item.FunctionFlags & (uint)EFunctionFlags.FUNC_Net) == (uint)EFunctionFlags.FUNC_Net)
            {
                reader.Read(ref item.RepOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION))
            {
                reader.Read(ref item.EventGraphFunction);
                reader.Read(ref item.EventGraphCallOffset);
            }
            ///if ((Ar.GetPortFlags() & PPF_Duplicate) != 0)
            ///{
            ///    Ar << NumParms;
            ///    Ar << ParmsSize;
            ///    Ar << ReturnValueOffset;
            ///    Ar << FirstPropertyToInit;
            ///}

            return item;
        }
    }
}
