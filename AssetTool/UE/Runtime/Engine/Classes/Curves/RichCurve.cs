namespace AssetTool
{
    [TransferibleStruct("RichCurveKey")]
    public class FRichCurveKey : ITransferible
    {
        public ERichCurveInterpMode InterpMode;
        public ERichCurveTangentMode TangentMode;
        public ERichCurveTangentWeightMode TangentWeightMode;
        public float Time;
        public float Value;
        public float ArriveTangent;
        public float ArriveTangentWeight;
        public float LeaveTangent;
        public float LeaveTangentWeight;

        [Location("bool FRichCurveKey::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_SERIALIZE_RICH_CURVE_KEY)
            {
                return default;
            }
            transfer.MoveEnum(ref InterpMode);
            transfer.MoveEnum(ref TangentMode);
            transfer.MoveEnum(ref TangentWeightMode);
            transfer.Move(ref Time);
            transfer.Move(ref Value);
            transfer.Move(ref ArriveTangent);
            transfer.Move(ref ArriveTangentWeight);
            transfer.Move(ref LeaveTangent);
            transfer.Move(ref LeaveTangentWeight);
            return this;
        }
    }

    public enum ERichCurveTangentMode : byte
    {
        RCTM_Auto,
        RCTM_User,
        RCTM_Break,
        RCTM_None,
        RCTM_SmartAuto
    }

    public enum ERichCurveTangentWeightMode : byte
    {
        RCTWM_WeightedNone,
        RCTWM_WeightedArrive,
        RCTWM_WeightedLeave,
        RCTWM_WeightedBoth
    }
}
