namespace AssetTool
{
    [TransferableStruct("ChaosClothAssetOrArrayType")]
    public class FChaosClothAssetOrArrayType : ITransferable
    {
        public TVariant<FObjectPtr, TList<FObjectPtr>> AssetOrArray;

        [Location("struct FChaosClothAssetOrArrayType")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref AssetOrArray);
            return this;
        }
    }
}
