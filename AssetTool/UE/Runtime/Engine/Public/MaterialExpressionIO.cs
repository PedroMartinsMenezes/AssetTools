namespace AssetTool.UE.Runtime.Engine.Public
{
    [TransferibleStruct("MaterialAttributesInput")]
    public class FMaterialAttributesInput : FExpressionInput, ITransferible
    {
        [Location("bool FMaterialAttributesInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
