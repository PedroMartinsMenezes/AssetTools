namespace AssetTool.Chaos
{
    public class TSegment : ITransferible
    {
        public TVec3 MPoint;
        public TVec3 MAxis;
        public float LengthFloat;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MPoint);
            transfer.Move(ref MAxis);
            transfer.Move(ref LengthFloat);
            return this;
        }
    }
}
