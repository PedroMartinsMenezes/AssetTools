namespace AssetTool
{
    public class FMeshMapBuildData : ITransferible
    {
        public UInt32 LightMap;
        public UInt32 ShadowMap;
        public List<FGuid> IrrelevantLights;
        public List<FPerInstanceLightmapData> PerInstanceLightmapData;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshMapBuildData& MeshMapBuildData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LightMap);
            transfer.Move(ref ShadowMap);
            transfer.Move(ref IrrelevantLights);
            transfer.Move(ref PerInstanceLightmapData);
            return this;
        }

        public ITransferible MoveValue(Transfer transfer)
        {
            transfer.Move(ref LightMap);
            transfer.Move(ref ShadowMap);
            return this;
        }
    }

    public class FPerInstanceLightmapData : ITransferible
    {
        public FVector2f LightmapUVBias;
        public FVector2f ShadowmapUVBias;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LightmapUVBias);
            transfer.Move(ref ShadowmapUVBias);
            return this;
        }
    }
}
