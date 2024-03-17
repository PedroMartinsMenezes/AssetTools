namespace AssetTool
{
    [Location("void ULightComponent::Serialize(FArchive& Ar)")]
    public class ULightComponent : ULightComponentBase
    {
        public FStaticShadowDepthMapData DepthMap;

        public new ULightComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STATIC_SHADOW_DEPTH_MAPS) && !Supports.CustomVer(FRenderingObjectVersion.Enums.MapBuildDataSeparatePackage))
            {
                DepthMap = new();
                DepthMap.Read(reader);
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STATIC_SHADOW_DEPTH_MAPS) && !Supports.CustomVer(FRenderingObjectVersion.Enums.MapBuildDataSeparatePackage))
            {
                DepthMap.Write(writer);
            }
        }
    }
}
