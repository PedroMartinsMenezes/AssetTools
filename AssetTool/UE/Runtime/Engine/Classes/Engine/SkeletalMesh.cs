namespace AssetTool
{
    [JsonAsset("SkeletalMesh")]
    public class USkeletalMesh : USkinnedAsset
    {
        public FStripDataFlags StripFlags;
        public FBoxSphereBounds LocalImportedBounds;
        public FBool bCooked;
        public Dictionary<FName, TInt32> DummyNameIndexMap;
        public UInt32[] DummyObjs;
        public float[] CachedStreamingTextureFactors;
        public FBool bHaveSourceData;
        public FSkeletalMeshLODModel DummyLODModel;
        public List<FClothingAssetData_Legacy> ClothingAssets_DEPRECATED;
        public byte bEnablePerPolyCollision;
        public UBodySetup LocalBodySetup;
        public List<FSkeletalMaterial> Materials;
        public FReferenceSkeleton RefSkeleton;
        public FSkeletalMeshModel ImportedModel;
        public FSkeletalMeshRenderData SkeletalMeshRenderData;
        public bool? bHasVertexColors;

        [Location("void USkeletalMesh::Serialize( FArchive& Ar )")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Members.FirstOrDefault(x => x.Key.Contains("bHasVertexColors")) is var value && value.Value is { })
            {
                bHasVertexColors = Convert.ToBoolean(value.Value.ToString());
            }

            transfer.Move(ref StripFlags);
            transfer.Move(ref LocalImportedBounds);
            transfer.Move(ref Materials);
            transfer.Move(ref RefSkeleton);
            if (!StripFlags.IsEditorDataStripped())
            {
                transfer.Move(ref ImportedModel, bHasVertexColors ?? false);
            }
            if (transfer.Supports.SplitModelAndRenderData)
            {
                transfer.Move(ref bCooked);
                if (bCooked)
                {
                    transfer.Move(ref SkeletalMeshRenderData);
                }
            }

            if (!transfer.Supports.VER_UE4_REFERENCE_SKELETON_REFACTOR)
            {
                transfer.Move(ref DummyNameIndexMap);
            }
            transfer.Move(ref DummyObjs);
            if (!transfer.Supports.TextureStreamingMeshUVChannelData)
            {
                transfer.Move(ref CachedStreamingTextureFactors);
            }
            if (!StripFlags.IsEditorDataStripped() && !transfer.Supports.RemoveSourceData)
            {
                transfer.Move(ref bHaveSourceData);
                if (bHaveSourceData.Value)
                {
                    transfer.Move(ref DummyLODModel, bHasVertexColors ?? false);
                }
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