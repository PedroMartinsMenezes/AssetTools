﻿namespace AssetTool
{
    [TransferibleStruct("RichCurveKey")]
    public class FRichCurveKey : ITransferible
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

        [Location("bool FRichCurveKey::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref InterpMode);
            transfer.Move(ref TangentMode);
            transfer.Move(ref TangentWeightMode);
            transfer.Move(ref Time);
            transfer.Move(ref Value);
            transfer.Move(ref ArriveTangent);
            transfer.Move(ref ArriveTangentWeight);
            transfer.Move(ref LeaveTangent);
            transfer.Move(ref LeaveTangentWeight);
            return this;
        }
    }
}
