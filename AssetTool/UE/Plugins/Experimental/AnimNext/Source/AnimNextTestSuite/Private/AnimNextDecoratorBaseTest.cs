namespace AssetTool
{
    [TransferibleStruct("DecoratorNativeSerialization_AddSharedData")]
    public class FDecoratorNativeSerialization_AddSharedData : FAnimNextDecoratorSharedData, ITransferible
    {
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }
}