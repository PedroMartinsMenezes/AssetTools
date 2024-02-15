namespace AssetTool
{
    public class FRichCurve
    {
        public List<FRichCurveKey> Keys;

        public FRichCurve() { }

        public FRichCurve(BinaryReader reader)
        {
            reader.ReadList(ref Keys);
        }

        public void Write(BinaryWriter writer)
        {
            writer.WriteList(Keys);
        }
    }
}
