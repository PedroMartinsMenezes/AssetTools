namespace AssetTool
{
    [TransferableStruct("DecoratorNativeSerialization_AddSharedData")]
    public class FDecoratorNativeSerialization_AddSharedData : FAnimNextDecoratorSharedData, ITransferable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}