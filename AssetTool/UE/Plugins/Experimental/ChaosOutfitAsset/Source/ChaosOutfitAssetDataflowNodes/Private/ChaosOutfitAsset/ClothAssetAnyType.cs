namespace AssetTool
{
    [TransferibleStruct("ChaosClothAssetOrArrayType")]
    public class FChaosClothAssetOrArrayType : ITransferible
    {
        public TVariant<FObjectPtr, TList<FObjectPtr>> AssetOrArray;

        [Location("struct FChaosClothAssetOrArrayType")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref AssetOrArray);
            return this;
        }
    }
}
