namespace AssetTool
{
    [TransferableStruct("ExpressionInput")]
    public class FExpressionInput : ITransferable
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
        public bool bUseConstantValue;

        [Location("bool FExpressionInput::Serialize(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            return SerializeExpressionInput(transfer) ? this : default;
        }

        [Location("static bool SerializeExpressionInput(FArchive& Ar, FExpressionInput& Input)")]
        public bool SerializeExpressionInput(Transfer transfer)
        {
            if (!transfer.Supports.MaterialInputNativeSerialize)
            {
                return false;
            }
            transfer.Move(ref Expression);
            transfer.Move(ref OutputIndex);
            if (transfer.Supports.PinsStoreFName)
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

    public class FMaterialInput<InputType> : FExpressionInput where InputType : ITransferable, new()
    {
        public bool UseConstant;
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

    [TransferableStruct("ColorMaterialInput")]
    public class FColorMaterialInput : FMaterialInput<FColor>, ITransferable
    {
        public FMaterialInput<FLinearColor> FLinearColor;

        [Location("bool FColorMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.MaterialInputUsesLinearColor)
            {
                return SerializeMaterialInput(transfer) ? this : default;
            }
            else
            {
                FLinearColor ??= new FMaterialInput<FLinearColor>();
                return FLinearColor.SerializeMaterialInput(transfer) ? this : default;
            }
        }
    }

    [TransferableStruct("ScalarMaterialInput")]
    public class FScalarMaterialInput : FMaterialInput<TFloat>, ITransferable
    {
        [Location("bool FScalarMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : default;
        }
    }

    //[TransferableStruct("ShadingModelMaterialInput")]
    public class FShadingModelMaterialInput : FMaterialInput<TUInt32>, ITransferable
    {
        [Location("bool FShadingModelMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : default;
        }
    }

    //[TransferableStruct("StrataMaterialInput")]
    public class FStrataMaterialInput : FMaterialInput<TUInt32>, ITransferable
    {
        [Location("bool FStrataMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : default;
        }
    }

    [TransferableStruct("Vector2MaterialInput")]
    public class FVector2MaterialInput : FMaterialInput<FVector2f>, ITransferable
    {
        [Location("bool FVector2MaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : default;
        }
    }

    [TransferableStruct("VectorMaterialInput")]
    public class FVectorMaterialInput : FMaterialInput<FVector3f>, ITransferable
    {
        [Location("bool FVectorMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return SerializeMaterialInput(transfer) ? this : default;
        }
    }

    [TransferableStruct("MaterialAttributesInput")]
    public class FMaterialAttributesInput : FExpressionInput, ITransferable
    {
        [Location("bool FMaterialAttributesInput::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return SerializeExpressionInput(transfer) ? this : default;
        }
    }
}
