namespace AssetTool
{
    [StructSerializable("StrataMaterialInput")]
    public class FStrataMaterialInput : FMaterialInput<UInt32>, ITransferible
    {
        public new const string StructName = "StrataMaterialInput";

        public FBool UseConstant;
        public UInt32 Constant = new();

        [Location("bool FStrataMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            transfer.Move(ref Constant);
            return this;
        }
    }
}
