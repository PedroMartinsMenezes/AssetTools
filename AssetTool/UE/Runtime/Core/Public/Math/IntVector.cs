namespace AssetTool
{
    #region Int32
    public class FIntVector2 : ITransferible
    {
        public Int32 X;
        public Int32 Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FIntVector3 : ITransferible
    {
        public Int32 X;
        public Int32 Y;
        public Int32 Z;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FIntVector4 : ITransferible
    {
        public Int32 X;
        public Int32 Y;
        public Int32 Z;
        public Int32 W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }
    #endregion

    #region UInt32
    public class FUIntVector2 : ITransferible
    {
        public UInt32 X;
        public UInt32 Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FUIntVector3 : ITransferible
    {
        public UInt32 X;
        public UInt32 Y;
        public UInt32 Z;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FUIntVector4 : ITransferible
    {
        public UInt32 X;
        public UInt32 Y;
        public UInt32 Z;
        public UInt32 W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }
    #endregion

    #region Int64
    public class FInt64Vector2 : ITransferible
    {
        public Int64 X;
        public Int64 Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FInt64Vector3 : ITransferible
    {
        public Int64 X;
        public Int64 Y;
        public Int64 Z;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FInt64Vector4 : ITransferible
    {
        public Int64 X;
        public Int64 Y;
        public Int64 Z;
        public Int64 W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }
    #endregion

    #region UInt64
    public class FUInt64Vector2 : ITransferible
    {
        public UInt64 X;
        public UInt64 Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FUInt64Vector3 : ITransferible
    {
        public UInt64 X;
        public UInt64 Y;
        public UInt64 Z;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FUInt64Vector4 : ITransferible
    {
        public UInt64 X;
        public UInt64 Y;
        public UInt64 Z;
        public UInt64 W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }
    #endregion
}
