namespace AssetTool.Geometry
{
    public class FIndex2i : ITransferible
    {
        public int A;
        public int B;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref A);
            transfer.Move(ref B);
            return this;
        }
    }

    public class FIndex3i : ITransferible
    {
        public int A;
        public int B;
        public int C;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref A);
            transfer.Move(ref B);
            transfer.Move(ref C);
            return this;
        }
    }

    public class FIndex4i : ITransferible
    {
        public int A;
        public int B;
        public int C;
        public int D;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref A);
            transfer.Move(ref B);
            transfer.Move(ref C);
            transfer.Move(ref D);
            return this;
        }
    }
}
