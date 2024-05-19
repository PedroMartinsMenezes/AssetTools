namespace AssetTool
{
    public class TInt8
    {
        public sbyte Value;

        public TInt8 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TInt16
    {
        public Int16 Value;

        public TInt16 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TInt32
    {
        public Int32 Value;

        public TInt32 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TInt64
    {
        public Int64 Value;

        public TInt64 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TUInt8
    {
        public byte Value;

        public TUInt8 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TUInt16
    {
        public UInt16 Value;

        public TUInt16 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TUInt32
    {
        public UInt32 Value;

        public TUInt32 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TUInt64
    {
        public UInt64 Value;

        public TUInt64 Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
