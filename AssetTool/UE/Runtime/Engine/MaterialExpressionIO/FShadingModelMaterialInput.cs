namespace AssetTool
{
    [TransferibleStruct("ShadingModelMaterialInput")]
    public class FShadingModelMaterialInput : FMaterialInput<UInt32>, ITransferible
    {
        public new const string StructName = "ShadingModelMaterialInput";

        public FBool UseConstant;
        public UInt32 Constant = new();

        [Location("bool FShadingModelMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            transfer.Move(ref Constant);
            return this;
        }
    }
}
