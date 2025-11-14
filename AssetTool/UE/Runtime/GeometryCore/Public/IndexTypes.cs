namespace AssetTool.Geometry
{
    public class FIndex2i : ITransferable
    {
        public int A;
        public int B;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref A);
            transfer.Move(ref B);
            return this;
        }
    }

    public class FIndex3i : ITransferable
    {
        public int A;
        public int B;
        public int C;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref A);
            transfer.Move(ref B);
            transfer.Move(ref C);
            return this;
        }
    }

    public class FIndex4i : ITransferable
    {
        public int A;
        public int B;
        public int C;
        public int D;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref A);
            transfer.Move(ref B);
            transfer.Move(ref C);
            transfer.Move(ref D);
            return this;
        }
    }
}
