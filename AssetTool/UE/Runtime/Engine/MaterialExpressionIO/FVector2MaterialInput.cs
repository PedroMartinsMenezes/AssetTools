namespace AssetTool
{
    [TransferibleStruct("Vector2MaterialInput")]
    public class FVector2MaterialInput : FMaterialInput<FVector2f>, ITransferible
    {
        public new const string StructName = "Vector2MaterialInput";

        public FBool UseConstant;
        public FVector2f Constant = new();

        [Location("bool FVector2MaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            Constant.Move(transfer);
            return this;
        }
    }
}
