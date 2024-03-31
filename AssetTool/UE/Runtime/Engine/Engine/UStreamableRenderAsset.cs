namespace AssetTool
{
    public class UStreamableRenderAsset : UObject
    {
        public FStripDataFlags StripFlags;
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
        public UInt32 SpeedTreeWind;
        public FMeshSectionInfoMap Map;
        public List<FStaticMaterial> StaticMaterials = [];

        public UStreamableRenderAsset Read(BinaryReader reader)
        {
            base.Read(reader);
            StripFlags = new FStripDataFlags().Read(reader);
            reader.Read(ref bCooked);
            reader.Read(ref LocalBodySetup);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STATIC_MESH_STORE_NAV_COLLISION))
            {
                reader.Read(ref LocalNavCollision);
            }
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_DEPRECATED_STATIC_MESH_THUMBNAIL_PROPERTIES_REMOVED))
            {
                DummyThumbnailAngle = new FRotator().ReadDouble(reader);
                reader.Read(ref DummyThumbnailDistance);
            }
            reader.Read(ref Deprecated_HighResSourceMeshName);
            reader.Read(ref Deprecated_HighResSourceMeshCRC);
            reader.Read(ref LocalLightingGuid);
            int count = reader.ReadInt32();
            Enumerable.Range(0, count).ToList().ForEach(x => Sockets.Add(reader.ReadUInt32()));
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SPEEDTREE_STATICMESH))
            {
                reader.Read(ref bHasSpeedTreeWind);
                if (bHasSpeedTreeWind.Value)
                {
                    reader.Read(ref SpeedTreeWind);
                }
            }
            if (!Supports.CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSection))
            {
                Map = new FMeshSectionInfoMap().Read(reader);
            }
            if (Supports.CustomVer(FEditorObjectVersion.Enums.RefactorMeshEditorMaterials))
            {
                count = reader.ReadInt32();
                Enumerable.Range(0, count).ToList().ForEach(x => StaticMaterials.Add(new FStaticMaterial().Read(reader)));
            }
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            StripFlags.Write(writer);
            writer.Write(bCooked);
            writer.Write(LocalBodySetup);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STATIC_MESH_STORE_NAV_COLLISION))
            {
                writer.Write(LocalNavCollision);
            }
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_DEPRECATED_STATIC_MESH_THUMBNAIL_PROPERTIES_REMOVED))
            {
                DummyThumbnailAngle.WriteDouble(writer);
                writer.Write(DummyThumbnailDistance);
            }
            writer.Write(Deprecated_HighResSourceMeshName);
            writer.Write(Deprecated_HighResSourceMeshCRC);
            writer.Write(LocalLightingGuid);
            writer.Write(Sockets.Count);
            Sockets.ForEach(x => writer.Write(x));
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SPEEDTREE_STATICMESH))
            {
                writer.Write(bHasSpeedTreeWind);
                if (bHasSpeedTreeWind.Value)
                {
                    writer.Write(SpeedTreeWind);
                }
            }
            if (!Supports.CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSection))
            {
                Map.Write(writer);
            }
            if (Supports.CustomVer(FEditorObjectVersion.Enums.RefactorMeshEditorMaterials))
            {
                writer.Write(StaticMaterials.Count);
                StaticMaterials.ForEach(x => x.Write(writer));
            }
        }
    }
}
