namespace AssetTool
{
    [TransferibleStruct("ExpressionInput")]
    public class FExpressionInput : ITransferible
    {
        public const string StructName = "ExpressionInput";

        public UInt32 Expression;
        public Int32 OutputIndex;
        public FName InputName;
        public FString InputNameStr;
        public Int32 Mask;
        public Int32 MaskR;
        public Int32 MaskG;
        public Int32 MaskB;
        public Int32 MaskA;
        public FBool bUseConstantValue;

        [Location("bool FExpressionInput::Serialize(FArchive& Ar)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            SerializeExpressionInput(transfer);
            return this;
        }

        [Location("static bool SerializeExpressionInput(FArchive& Ar, FExpressionInput& Input)")]
        public bool SerializeExpressionInput(Transfer transfer)
        {
            if (!Supports.MaterialInputNativeSerialize)
            {
                return false;
            }
            transfer.Move(ref Expression);
            transfer.Move(ref OutputIndex);
            if (Supports.PinsStoreFName)
            {
                transfer.Move(ref InputName);
            }
            else
            {
                transfer.Move(ref InputNameStr);
            }
            transfer.Move(ref Mask);
            transfer.Move(ref MaskR);
            transfer.Move(ref MaskG);
            transfer.Move(ref MaskB);
            transfer.Move(ref MaskA);
            return true;
        }
    }

    public abstract class FMaterialInput<InputType> : FExpressionInput where InputType : ITransferible
    {
        public FBool UseConstant;
        public InputType Constant;

        [Location("static bool SerializeMaterialInput(FArchive& Ar, FMaterialInput<InputType>& Input)")]
        public bool SerializeMaterialInput(Transfer transfer)
        {
            if (SerializeExpressionInput(transfer))
            {
                transfer.Move(ref UseConstant);
                transfer.Move(ref Constant);
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    [TransferibleStruct("ColorMaterialInput")]
    public class FColorMaterialInput : FMaterialInput<FColor>, ITransferible
    {
        [Location("bool FColorMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : null;
        }
    }

    [TransferibleStruct("ScalarMaterialInput")]
    public class FScalarMaterialInput : FMaterialInput<TFloat>, ITransferible
    {
        [Location("bool FScalarMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : null;
        }
    }

    [TransferibleStruct("ShadingModelMaterialInput")]
    public class FShadingModelMaterialInput : FMaterialInput<TUInt32>, ITransferible
    {
        [Location("bool FShadingModelMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : null;
        }
    }

    [TransferibleStruct("StrataMaterialInput")]
    public class FStrataMaterialInput : FMaterialInput<TUInt32>, ITransferible
    {
        [Location("bool FStrataMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : null;
        }
    }

    [TransferibleStruct("Vector2MaterialInput")]
    public class FVector2MaterialInput : FMaterialInput<FVector2f>, ITransferible
    {
        [Location("bool FVector2MaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : null;
        }
    }

    [TransferibleStruct("VectorMaterialInput")]
    public class FVectorMaterialInput : FMaterialInput<FVector3f>, ITransferible
    {
        [Location("bool FVectorMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : null;
        }
    }

    [TransferibleStruct("MaterialAttributesInput")]
    public class FMaterialAttributesInput : FExpressionInput, ITransferible
    {
        [Location("bool FMaterialAttributesInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return SerializeExpressionInput(transfer) ? this : null;
        }
    }
}
