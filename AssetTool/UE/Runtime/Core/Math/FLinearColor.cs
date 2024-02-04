namespace AssetTool
{
    public class FLinearColor
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public const string StructName = "LinearColor";

        public FLinearColor() { }

        public FLinearColor(BinaryReader reader)
        {
            R = reader.ReadSingle();
            G = reader.ReadSingle();
            B = reader.ReadSingle();
            A = reader.ReadSingle();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(R);
            writer.Write(G);
            writer.Write(B);
            writer.Write(A);
        }
    }
}
