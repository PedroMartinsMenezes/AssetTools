namespace AssetTool
{
    public class FPlane : FVector
    {
        public double W;

        public new FPlane Read(BinaryReader reader)
        {
            W = reader.ReadDouble();
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            writer.Write(W);
        }
    }
}
