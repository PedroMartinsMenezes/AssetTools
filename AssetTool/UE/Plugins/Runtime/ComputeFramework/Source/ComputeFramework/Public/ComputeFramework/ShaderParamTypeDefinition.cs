namespace AssetTool
{
    [TransferibleStruct("ShaderValueTypeHandle")]
    public class FShaderValueTypeHandle : ITransferible
    {
        public FShaderValueType ValueTypePtr = new();

        [Location("FArchive& operator<<(FArchive& InArchive, FShaderValueTypeHandle& InHandle)")]
        public ITransferible Move(Transfer transfer)
        {
            ValueTypePtr.Type = (EShaderFundamentalType)transfer.Move((byte)ValueTypePtr.Type);
            if (Supports.InitialVersion)
            {
                transfer.Move(ref ValueTypePtr.bIsDynamicArray);
            }
            if (ValueTypePtr.Type == EShaderFundamentalType.Struct)
            {
                transfer.Move(ref ValueTypePtr.Name);
                transfer.Move(ref ValueTypePtr.StructElements);
            }
            else
            {
                ValueTypePtr.DimensionType = (EShaderFundamentalDimensionType)transfer.Move((byte)ValueTypePtr.DimensionType);

                if (ValueTypePtr.DimensionType == EShaderFundamentalDimensionType.Vector)
                {
                    transfer.Move(ref ValueTypePtr.VectorElemCount);
                }
                else if (ValueTypePtr.DimensionType == EShaderFundamentalDimensionType.Matrix)
                {
                    transfer.Move(ref ValueTypePtr.MatrixRowCount);
                    transfer.Move(ref ValueTypePtr.MatrixColumnCount);
                }
            }
            return this;
        }
    }

    public class FShaderValueType : ITransferible
    {
        public EShaderFundamentalType Type;
        public FBool bIsDynamicArray;
        public FName Name;
        public List<FStructElement> StructElements;
        public EShaderFundamentalDimensionType DimensionType;
        public byte VectorElemCount;
        public byte MatrixRowCount;
        public byte MatrixColumnCount;

        public ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }

    public class FStructElement : ITransferible
    {
        public FName Name;
        public FShaderValueTypeHandle Type;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref Type);
            return this;
        }
    }

    public enum EShaderFundamentalType : byte
    {
        Bool = 0,
        Int = 1,
        Uint = 2,
        Float = 3,
        Struct = 4,
        None = 255,
    }

    public enum EShaderFundamentalDimensionType : byte
    {
        Scalar,
        Vector,
        Matrix
    }
}