namespace AssetTool
{
    public class FInterpCurvePoint<T> : ITransferible where T : ITransferible, new()
    {
        public float InVal;
        public T OutVal;
        public T ArriveTangent;
        public T LeaveTangent;
        public EInterpCurveMode InterpMode;

        [Location("friend FArchive& operator<<( FArchive& Ar, FInterpCurvePoint& Point )")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref InVal);
            transfer.Move(ref OutVal);
            transfer.Move(ref ArriveTangent);
            transfer.Move(ref LeaveTangent);
            transfer.MoveEnum(ref InterpMode);
            return this;
        }
    }

    public enum EInterpCurveMode : uint8
    {
        CIM_Linear,
        CIM_CurveAuto,
        CIM_Constant,
        CIM_CurveUser,
        CIM_CurveBreak,
        CIM_CurveAutoClamped,
        CIM_Unknown
    }
}
