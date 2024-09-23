namespace AssetTool
{
    using System;
    using FBoxSphereBounds = FBoxSphereBounds3d;

    [JsonAsset("SkeletalMesh")]
    public class USkeletalMesh : USkinnedAsset
    {
        public FStripDataFlags StripFlags = new();
        public FBoxSphereBounds LocalImportedBounds = new();
        public FBool bCooked;
        public Dictionary<FName, TInt32> DummyNameIndexMap;
        public List<UInt32> DummyObjs = [];
        public List<float> CachedStreamingTextureFactors;
        public FBool bHaveSourceData;
        public FSkeletalMeshLODModel DummyLODModel;
        public List<FClothingAssetData_Legacy> ClothingAssets_DEPRECATED;
        public byte bEnablePerPolyCollision;
        public UBodySetup LocalBodySetup;
        public List<FSkeletalMaterial> Materials = [];
        public FReferenceSkeleton RefSkeleton = new();
        public FSkeletalMeshModel ImportedModel;

        [Location("void USkeletalMesh::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            StripFlags.Move(transfer);

            LocalImportedBounds.Move(transfer);

            Materials.Resize(transfer).ForEach(x => x.Move(transfer));

            RefSkeleton.Move(transfer);

            if (!StripFlags.IsEditorDataStripped())
            {
                ImportedModel.Move(transfer);
            }

            if (Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.SplitModelAndRenderData))
            {
                transfer.Move(ref bCooked);
            }

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_REFERENCE_SKELETON_REFACTOR))
            {
                DummyNameIndexMap ??= new();
                DummyNameIndexMap.Move(transfer, (key) => transfer.Move(key), (value) => value.Move(transfer));
            }

            transfer.Move(ref DummyObjs);

            if (Supports.CustomVer(FRenderingObjectVersion.Enums.TextureStreamingMeshUVChannelData))
            {
                CachedStreamingTextureFactors ??= new();
                transfer.Move(ref CachedStreamingTextureFactors);
            }

            if (!StripFlags.IsEditorDataStripped() && !Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.RemoveSourceData))
            {
                transfer.Move(ref bHaveSourceData);
                if (bHaveSourceData.Value)
                {
                    DummyLODModel ??= new();
                    DummyLODModel.Move(transfer);
                }
            }

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_APEX_CLOTH) && !Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.NewClothingSystemAdded))
            {
                ClothingAssets_DEPRECATED.Resize(transfer);
                ClothingAssets_DEPRECATED.ForEach(x => x.Move(transfer));
            }

            if (bEnablePerPolyCollision != 0)
            {
                LocalBodySetup ??= new();
                LocalBodySetup.Move(transfer);
            }

            return this;
        }
    }

    public class FClothingAssetData_Legacy
    {
        public byte[] Buffer;

        [Location("FArchive& operator<<(FArchive& Ar, FClothingAssetData_Legacy& A)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref Buffer);
        }
    }
}
