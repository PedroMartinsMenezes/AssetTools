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

        public new UFunction Read(BinaryReader reader)
        {
            base.Read(reader);

            reader.Read(ref FunctionFlags);

            if ((FunctionFlags & (uint)EFunctionFlags.FUNC_Net) == (uint)EFunctionFlags.FUNC_Net)
            {
                reader.Read(ref RepOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION))
            {
                reader.Read(ref EventGraphFunction);
                reader.Read(ref EventGraphCallOffset);
            }
            ///if ((Ar.GetPortFlags() & PPF_Duplicate) != 0)
            ///{
            ///    Ar << NumParms;
            ///    Ar << ParmsSize;
            ///    Ar << ReturnValueOffset;
            ///    Ar << FirstPropertyToInit;
            ///}

            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            writer.Write(FunctionFlags);

            if ((FunctionFlags & (uint)EFunctionFlags.FUNC_Net) == (uint)EFunctionFlags.FUNC_Net)
            {
                writer.Write(RepOffset);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION))
            {
                writer.Write(EventGraphFunction);
                writer.Write(EventGraphCallOffset);
            }
            ///if ((Ar.GetPortFlags() & PPF_Duplicate) != 0)
            ///{
            ///    Ar << NumParms;
            ///    Ar << ParmsSize;
            ///    Ar << ReturnValueOffset;
            ///    Ar << FirstPropertyToInit;
            ///}
        }
    }
}
