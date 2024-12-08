namespace AssetTool
{
    [JsonAsset("SkeletalMesh")]
    public class USkeletalMesh : USkinnedAsset
    {
        public FStripDataFlags StripFlags;
        public FBoxSphereBounds LocalImportedBounds;
        public FBool bCooked;
        public Dictionary<FName, TInt32> DummyNameIndexMap;
        public List<UInt32> DummyObjs = [];
        public List<float> CachedStreamingTextureFactors;
        public FBool bHaveSourceData;
        public FSkeletalMeshLODModel DummyLODModel;
        public List<FClothingAssetData_Legacy> ClothingAssets_DEPRECATED;
        public byte bEnablePerPolyCollision;
        public UBodySetup LocalBodySetup;
        public List<FSkeletalMaterial> Materials;
        public FReferenceSkeleton RefSkeleton;
        public FSkeletalMeshModel ImportedModel;

        [Location("void USkeletalMesh::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            transfer.Move(ref LocalImportedBounds);
            transfer.Move(ref Materials);
            transfer.Move(ref RefSkeleton);
            if (!StripFlags.IsEditorDataStripped())
            {
                transfer.Move(ref ImportedModel);
            }
            if (Supports.SplitModelAndRenderData)
            {
                transfer.Move(ref bCooked);
            }
            if (bCooked)
            {
                throw new NotImplementedException();
            }
            if (!Supports.VER_UE4_REFERENCE_SKELETON_REFACTOR)
            {
                transfer.Move(ref DummyNameIndexMap);
            }
            transfer.Move(ref DummyObjs);
            if (!Supports.TextureStreamingMeshUVChannelData)
            {
                CachedStreamingTextureFactors ??= new();
                transfer.Move(ref CachedStreamingTextureFactors);
            }
            if (!StripFlags.IsEditorDataStripped() && !Supports.RemoveSourceData)
            {
                transfer.Move(ref bHaveSourceData);
                if (bHaveSourceData.Value)
                {
                    transfer.Move(ref DummyLODModel);
                }
            }
            if (Supports.VER_UE4_APEX_CLOTH && !Supports.NewClothingSystemAdded)
            {
                transfer.Move(ref ClothingAssets_DEPRECATED);
            }
            if (bEnablePerPolyCollision != 0)
            {
                LocalBodySetup ??= new();
                LocalBodySetup.Move(transfer);
            }
            return this;
        }
    }

    public class FClothingAssetData_Legacy : ITransferible
    {
        public byte[] Buffer;

        [Location("FArchive& operator<<(FArchive& Ar, FClothingAssetData_Legacy& A)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Buffer);
            return this;
        }
    }
}