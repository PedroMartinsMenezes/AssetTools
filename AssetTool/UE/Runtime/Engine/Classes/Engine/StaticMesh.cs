namespace AssetTool
{
    [JsonAsset("StaticMesh")]
    public class UStaticMesh : UStreamableRenderAsset
    {
        public FStripDataFlags StripFlags = new();
        public FBool bCooked;
        public UInt32 LocalBodySetup;
        public UInt32 LocalNavCollision;
        public FRotator DummyThumbnailAngle;
        public float DummyThumbnailDistance;
        public FString Deprecated_HighResSourceMeshName;
        public UInt32 Deprecated_HighResSourceMeshCRC;
        public FGuid LocalLightingGuid;
        public List<UInt32> Sockets = [];
        public FBool bHasSpeedTreeWind;
        public FSpeedTreeWind SpeedTreeWind;
        public FMeshSectionInfoMap SectionInfoMap;
        public List<FStaticMaterial> StaticMaterials;
        public List<FStaticMeshSourceModel> SourceModels;
        public FStaticMeshRenderData RenderData;

        [Location("void UStaticMesh::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (GlobalObjects.CurrentObject.ArrayNames.TryGetValue("SourceModels", out int size))
            {
                SourceModels = SourceModels.Resize(transfer, size);
            }
            StripFlags.Move(transfer);
            transfer.Move(ref bCooked);
            transfer.Move(ref LocalBodySetup);
            if (Supports.VER_UE4_STATIC_MESH_STORE_NAV_COLLISION)
            {
                transfer.Move(ref LocalNavCollision);
            }
            if (!StripFlags.IsEditorDataStripped() && !Supports.VER_UE4_DEPRECATED_STATIC_MESH_THUMBNAIL_PROPERTIES_REMOVED)
            {
                DummyThumbnailAngle ??= new();
                DummyThumbnailAngle.Move(transfer);
                transfer.Move(ref DummyThumbnailDistance);
            }
            if (!StripFlags.IsEditorDataStripped())
            {
                transfer.Move(ref Deprecated_HighResSourceMeshName);
                transfer.Move(ref Deprecated_HighResSourceMeshCRC);

            }
            transfer.Move(ref LocalLightingGuid);
            transfer.Move(ref Sockets);
            if (!StripFlags.IsEditorDataStripped())
            {
                for (int i = 0; i < SourceModels.Count; ++i)
                {
                    SourceModels[i].Move(transfer);
                }
                if (!Supports.UPropertryForMeshSection)
                {
                    transfer.Move(ref SectionInfoMap);
                }
            }
            if (bCooked)
            {
                transfer.Move(ref RenderData);
            }
            if (Supports.VER_UE4_SPEEDTREE_STATICMESH)
            {
                transfer.Move(ref bHasSpeedTreeWind);
                if (bHasSpeedTreeWind.Value)
                {
                    transfer.Move(ref SpeedTreeWind);
                }
            }
            if (!Supports.UPropertryForMeshSection)
            {
                transfer.Move(ref SectionInfoMap);
            }
            if (Supports.RefactorMeshEditorMaterials)
            {
                transfer.Move(ref StaticMaterials);
            }
            return this;
        }
    }
}