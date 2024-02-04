namespace AssetTool
{
    public class FPointerToUberGraphFrame
    {
        public UInt32 RawPointer;
        public UInt32 UberGraphFunctionKey;

        public const string StructName = "PointerToUberGraphFrame";

        public FPointerToUberGraphFrame() { }

        public FPointerToUberGraphFrame(BinaryReader reader)
        {
            RawPointer = reader.ReadUInt32();
            UberGraphFunctionKey = reader.ReadUInt32();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(RawPointer);
            writer.Write(UberGraphFunctionKey);
        }
    }
}
