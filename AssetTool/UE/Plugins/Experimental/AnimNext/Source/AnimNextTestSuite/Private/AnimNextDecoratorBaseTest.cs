namespace AssetTool
{
    [TransferibleStruct("DecoratorNativeSerialization_AddSharedData")]
    public class FDecoratorNativeSerialization_AddSharedData : FAnimNextDecoratorSharedData, ITransferible
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}