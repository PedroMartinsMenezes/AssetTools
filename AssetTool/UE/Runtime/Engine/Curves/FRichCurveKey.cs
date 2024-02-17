namespace AssetTool
{
    [Location("bool FRichCurveKey::Serialize(FArchive& Ar)")]
    public class FRichCurveKey
    {
        public const string StructName = "RichCurveKey";

        public byte InterpMode;
        public byte TangentMode;
        public byte TangentWeightMode;
        public float Time;
        public float Value;
        public float ArriveTangent;
        public float ArriveTangentWeight;
        public float LeaveTangent;
        public float LeaveTangentWeight;

        public FRichCurveKey() { }

        public FRichCurveKey(BinaryReader reader)
        {
            reader.Read(ref InterpMode);
            reader.Read(ref TangentMode);
            reader.Read(ref TangentWeightMode);
            reader.Read(ref Time);
            reader.Read(ref Value);
            reader.Read(ref ArriveTangent);
            reader.Read(ref ArriveTangentWeight);
            reader.Read(ref LeaveTangent);
            reader.Read(ref LeaveTangentWeight);
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(InterpMode);
            writer.Write(TangentMode);
            writer.Write(TangentWeightMode);
            writer.Write(Time);
            writer.Write(Value);
            writer.Write(ArriveTangent);
            writer.Write(ArriveTangentWeight);
            writer.Write(LeaveTangent);
            writer.Write(LeaveTangentWeight);
        }
    }
}
