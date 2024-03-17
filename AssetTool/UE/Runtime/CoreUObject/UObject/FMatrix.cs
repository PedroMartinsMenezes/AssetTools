namespace AssetTool
{
    public class FMatrix
    {
        public FPlane XPlane = new();
        public FPlane YPlane = new();
        public FPlane ZPlane = new();
        public FPlane WPlane = new();

        public FMatrix Read(BinaryReader reader)
        {
            XPlane.Read(reader);
            YPlane.Read(reader);
            ZPlane.Read(reader);
            WPlane.Read(reader);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            XPlane.Write(writer);
            YPlane.Write(writer);
            ZPlane.Write(writer);
            WPlane.Write(writer);
        }
    }
}
