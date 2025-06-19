namespace AssetTool
{
    [JsonAsset("LightComponent")]
    public class ULightComponent : ULightComponentBase
    {
        public FStaticShadowDepthMapData DepthMap;

        [Location("void ULightComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VER_UE4_STATIC_SHADOW_DEPTH_MAPS && !transfer.Supports.MapBuildDataSeparatePackage)
            {
                transfer.Move(ref DepthMap);
            }
            return this;
        }
    }
}