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

        [Location("static bool SerializeExpressionInput(FArchive& Ar, FExpressionInput& Input)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            if (!Supports.MaterialInputNativeSerialize)
            {
                return this;
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
            return this;
        }
    }
}
