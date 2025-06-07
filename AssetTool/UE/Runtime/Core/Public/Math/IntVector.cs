namespace AssetTool
{
    #region Int32
    [TransferibleStruct("IntVector2")]
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

    [TransferibleStruct("IntVector")]
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

    [TransferibleStruct("IntVector4")]
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
    [TransferibleStruct("UIntVector2")]
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

    [TransferibleStruct("UIntVector")]
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

    [TransferibleStruct("UIntVector4")]
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

    [TransferibleStruct("Int64Vector2")]
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

    [TransferibleStruct("Int64Vector")]
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

    [TransferibleStruct("Int64Vector4")]
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
    [TransferibleStruct("UInt64Vector2")]
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

    [TransferibleStruct("UInt64Vector")]
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

    [TransferibleStruct("UInt64Vector4")]
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
