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
    }
}
