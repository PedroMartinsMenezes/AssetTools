using System.Diagnostics;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class TRotation3d : ITransferible
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class TRotation3f : ITransferible
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }
}
