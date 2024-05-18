namespace AssetTool
{
    public class FStructScriptLoader
    {
        public Int32 BytecodeBufferSize;
        public Int32 SerializedScriptSize;
        public Int64 ScriptSerializationOffset;
        public byte[] ScriptData = [];

        public FStructScriptLoader() { }

        public void Construct(Transfer transfer)
        {
            transfer.Move(ref BytecodeBufferSize);
            transfer.Move(ref SerializedScriptSize);
        }

        [Location("bool FStructScriptLoader::LoadStructWithScript(UStruct* DestScriptContainer, FArchive& Ar, bool bAllowDeferredSerialization)")]
        public void LoadStructWithScript(Transfer transfer)
        {
            ScriptSerializationOffset = SerializedScriptSize > 0 ? transfer.Position : 0;
            long ScriptEndOffset = ScriptSerializationOffset + SerializedScriptSize;
            if (ScriptEndOffset > ScriptSerializationOffset)
            {
                transfer.Move(ref ScriptData, (int)ScriptEndOffset - (int)ScriptSerializationOffset);
            }
        }

        //[Location("bool FStructScriptLoader::LoadStructWithScript(UStruct* DestScriptContainer, FArchive& Ar, bool bAllowDeferredSerialization)")]
        //public void LoadStructWithScript(BinaryReader reader)
        //{
        //    ScriptSerializationOffset = SerializedScriptSize > 0 ? reader.BaseStream.Position : 0;
        //    long ScriptEndOffset = ScriptSerializationOffset + SerializedScriptSize;
        //    if (ScriptEndOffset > ScriptSerializationOffset)
        //    {
        //        ScriptData = new byte[ScriptEndOffset - ScriptSerializationOffset];
        //        reader.Read(ScriptData);
        //    }
        //}

        //[Location("bool FStructScriptLoader::LoadStructWithScript(UStruct* DestScriptContainer, FArchive& Ar, bool bAllowDeferredSerialization)")]
        //public void LoadStructWithScript(BinaryWriter writer)
        //{
        //    long ScriptEndOffset = ScriptSerializationOffset + SerializedScriptSize;
        //    if (ScriptEndOffset > ScriptSerializationOffset)
        //    {
        //        writer.Write(ScriptData);
        //    }
        //}
    }
}
