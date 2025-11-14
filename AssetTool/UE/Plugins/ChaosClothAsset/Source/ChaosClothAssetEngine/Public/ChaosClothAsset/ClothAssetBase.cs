namespace AssetTool
{
    [JsonAsset("ChaosClothAssetBase")]
    public class UChaosClothAssetBase : USkinnedAsset
    {
        public FReferenceSkeleton RefSkeleton;

        [Location("void UChaosClothAssetBase::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.AddClothAssetBase)
            {
                transfer.Move(ref RefSkeleton);
            }
            return this;
        }
    }
}