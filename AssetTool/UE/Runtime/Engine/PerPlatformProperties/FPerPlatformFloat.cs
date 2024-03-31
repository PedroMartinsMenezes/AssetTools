namespace AssetTool.UE.Runtime.Engine
{
    public class FPerPlatformFloat
    {
        public const string StructName = "PerPlatformFloat";

        public FBool bCooked;
        public float Value;
        public TMap1<FName, Int32> PerPlatform = [];

        public FPerPlatformFloat Read(BinaryReader reader)
        {
            reader.Read(ref bCooked);
            reader.Read(ref Value);
            if (!bCooked.Value)
            {
                reader.ReadValue(PerPlatform, GetType().GetField("PerPlatform"));
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(bCooked);
            writer.Write(Value);
            if (!bCooked.Value)
            {
                writer.WriteValue(PerPlatform, GetType().GetField("PerPlatform"));
            }
        }
    }
}
