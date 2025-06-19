namespace AssetTool.Chaos
{
    public class PMatrix32f : ITransferible
    {
        public float[] M = [0, 0, 0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix32d : ITransferible
    {
        public double[] M = [0, 0, 0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix22f : ITransferible
    {
        public float[] M = [0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix22d : ITransferible
    {
        public double[] M = [0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix44f : ITransferible
    {
        public float[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix44d : ITransferible
    {
        public double[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix33f : ITransferible
    {
        public float[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }

    public class PMatrix33d : ITransferible
    {
        public double[] M = [0, 0, 0, 0, 0, 0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M);
            return this;
        }
    }
}
