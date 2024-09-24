namespace AssetTool
{
    [TransferibleStruct("ExpressionInput")]
    public class FExpressionInput : ITransferible
    {
        public const string StructName = "ExpressionInput";

        public UInt64 Expression;
        public Int32 OutputIndex;
        public FName InputName;
        public Int32 Mask;
        public Int32 MaskR;
        public Int32 MaskG;
        public Int32 MaskB;
        public Int32 MaskA;

        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Expression);
            transfer.Move(ref InputName);
            transfer.Move(ref Mask);
            transfer.Move(ref MaskR);
            transfer.Move(ref MaskG);
            transfer.Move(ref MaskB);
            transfer.Move(ref MaskA);
            return this;
        }
    }
}
