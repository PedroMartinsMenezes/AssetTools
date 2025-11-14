namespace AssetTool
{
    [TransferableStruct("ShaderValueTypeHandle")]
    public class FShaderValueTypeHandle : ITransferable
    {
        public FShaderValueType ValueTypePtr = new();

        [Location("FArchive& operator<<(FArchive& InArchive, FShaderValueTypeHandle& InHandle)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref ValueTypePtr.Type);
            if (transfer.Supports.InitialVersion)
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
                transfer.MoveEnum(ref ValueTypePtr.DimensionType);
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

    public class FShaderValueType : ITransferable
    {
        public EShaderFundamentalType Type;
        public FBool bIsDynamicArray;
        public FName Name;
        public List<FStructElement> StructElements;
        public EShaderFundamentalDimensionType DimensionType;
        public byte VectorElemCount;
        public byte MatrixRowCount;
        public byte MatrixColumnCount;

        public ITransferable Move(Transfer transfer)
        {
            return this;
        }
    }

    public class FStructElement : ITransferable
    {
        public FName Name;
        public FShaderValueTypeHandle Type;

        public ITransferable Move(Transfer transfer)
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