namespace AssetTool.Chaos
{
    public class PMatrix32f : ITransferable
    {
        public float[] M = [0, 0, 0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix32d : ITransferable
    {
        public double[] M = [0, 0, 0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix22f : ITransferable
    {
        public float[] M = [0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix22d : ITransferable
    {
        public double[] M = [0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix44f : ITransferable
    {
        public float[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix44d : ITransferable
    {
        public double[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix33f : ITransferable
    {
        public float[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix33d : ITransferable
    {
        public double[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }
}
