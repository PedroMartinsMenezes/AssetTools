namespace AssetTool
{
    [JsonAsset("StaticMesh")]
    public class UStaticMesh : UStreamableRenderAsset
    {
        public FStripDataFlags StripFlags = new();
        public FBool bCooked;
        public UInt32 LocalBodySetup;
        public UInt32 LocalNavCollision;
        public FRotator3d DummyThumbnailAngle;
        public float DummyThumbnailDistance;
        public FString Deprecated_HighResSourceMeshName;
        public UInt32 Deprecated_HighResSourceMeshCRC;
        public FGuid LocalLightingGuid;
        public List<UInt32> Sockets = [];
        public FBool bHasSpeedTreeWind;
        public UInt32 SpeedTreeWind;
        public FMeshSectionInfoMap Map;
        public List<FStaticMaterial> StaticMaterials;

        [Location("void UStaticMesh::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            StripFlags.Move(transfer);
            transfer.Move(ref bCooked);
            transfer.Move(ref LocalBodySetup);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STATIC_MESH_STORE_NAV_COLLISION))
            {
                transfer.Move(ref LocalNavCollision);
            }
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_DEPRECATED_STATIC_MESH_THUMBNAIL_PROPERTIES_REMOVED))
            {
                DummyThumbnailAngle ??= new();
                DummyThumbnailAngle.Move(transfer);

                transfer.Move(ref DummyThumbnailDistance);
            }
            transfer.Move(ref Deprecated_HighResSourceMeshName);
            transfer.Move(ref Deprecated_HighResSourceMeshCRC);
            transfer.Move(ref LocalLightingGuid);

            transfer.Move(ref Sockets);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SPEEDTREE_STATICMESH))
            {
                transfer.Move(ref bHasSpeedTreeWind);
                if (bHasSpeedTreeWind.Value)
                {
                    transfer.Move(ref SpeedTreeWind);
                }
            }

            if (!Supports.CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSection))
            {
                Map ??= new();
                Map.Move(transfer);
            }
            if (Supports.CustomVer(FEditorObjectVersion.Enums.RefactorMeshEditorMaterials))
            {
                transfer.Move(ref StaticMaterials);
            }
            return this;
        }
    }
}