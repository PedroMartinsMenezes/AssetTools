namespace AssetTool
{
    [Location("void ULightComponent::Serialize(FArchive& Ar)")]
    public class ULightComponent : ULightComponentBase
    {
        public FStaticShadowDepthMapData DepthMap = new();

        public new ULightComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STATIC_SHADOW_DEPTH_MAPS) && !Supports.CustomVer(FRenderingObjectVersion.Enums.MapBuildDataSeparatePackage))
            {
                DepthMap.Move(transfer);
            }
            return this;
        }
    }
}
