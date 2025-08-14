namespace AssetTool
{
    [JsonAsset("ChaosOutfitAsset")]
    public class UChaosOutfitAsset : UChaosClothAssetBase
    {
        public bool bCooked;
        public FSkeletalMeshRenderData SkeletalMeshRenderData;

        [Location("void UChaosOutfitAsset::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bCooked);
            if (bCooked)
            {
                transfer.Move(ref SkeletalMeshRenderData);
            }
            return this;
        }
    }
}