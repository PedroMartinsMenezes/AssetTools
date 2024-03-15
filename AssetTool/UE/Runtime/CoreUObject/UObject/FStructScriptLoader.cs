namespace AssetTool
{
    public class FStructScriptLoader
    {
        public Int32 BytecodeBufferSize;
        public Int32 SerializedScriptSize;
        public Int64 ScriptSerializationOffset;
        public byte[] ScriptData = [];

        public FStructScriptLoader() { }

        public void Construct(BinaryReader reader)
        {
            BytecodeBufferSize = reader.ReadInt32();
            SerializedScriptSize = reader.ReadInt32();
        }

        public void Construct(BinaryWriter writer)
        {
            writer.Write(BytecodeBufferSize);
            writer.Write(SerializedScriptSize);
        }

        [Location("bool FStructScriptLoader::LoadStructWithScript(UStruct* DestScriptContainer, FArchive& Ar, bool bAllowDeferredSerialization)")]
        public void LoadStructWithScript(BinaryReader reader)
        {
            ScriptSerializationOffset = SerializedScriptSize > 0 ? reader.BaseStream.Position : 0;
            long ScriptEndOffset = ScriptSerializationOffset + SerializedScriptSize;
            if (ScriptEndOffset > ScriptSerializationOffset)
            {
                ScriptData = new byte[ScriptEndOffset - ScriptSerializationOffset];
                reader.Read(ScriptData);
                ///reader.BaseStream.Position = ScriptEndOffset;
            }
        }

        [Location("bool FStructScriptLoader::LoadStructWithScript(UStruct* DestScriptContainer, FArchive& Ar, bool bAllowDeferredSerialization)")]
        public void LoadStructWithScript(BinaryWriter writer)
        {
            long ScriptEndOffset = ScriptSerializationOffset + SerializedScriptSize;
            if (ScriptEndOffset > ScriptSerializationOffset)
            {
                writer.Write(ScriptData);
            }
        }
    }
}
