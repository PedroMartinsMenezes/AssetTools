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
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref bCooked);
            transfer.Move(ref Value);
            if (!bCooked.Value)
            {
                reader.ReadValue(PerPlatform, GetType().GetField("PerPlatform"));
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref bCooked);
            transfer.Move(ref Value);
            if (!bCooked.Value)
            {
                writer.WriteValue(PerPlatform, GetType().GetField("PerPlatform"));
            }
        }
    }
}
