namespace AssetTool
{
    public struct FLightmassPrimitiveSettings : ITransferable
    {
        public FBool bUseTwoSidedLighting;
        public FBool bShadowIndirectOnly;
        public float FullyOccludedSamplesFraction;
        public FBool bUseEmissiveForStaticLighting;
        public FBool bUseVertexNormalForHemisphereGather;
        public float EmissiveLightFalloffExponent;
        public float EmissiveLightExplicitInfluenceRadius;
        public float EmissiveBoost;
        public float DiffuseBoost;

        [Location("FArchive& operator<<(FArchive& Ar, FLightmassPrimitiveSettings& Settings)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bUseTwoSidedLighting);
            transfer.Move(ref bShadowIndirectOnly);
            transfer.Move(ref FullyOccludedSamplesFraction);
            transfer.Move(ref bUseEmissiveForStaticLighting);
            if (transfer.Supports.VER_UE4_NEW_LIGHTMASS_PRIMITIVE_SETTING)
            {
                transfer.Move(ref bUseVertexNormalForHemisphereGather);
            }
            transfer.Move(ref EmissiveLightFalloffExponent);
            transfer.Move(ref EmissiveLightExplicitInfluenceRadius);
            transfer.Move(ref EmissiveBoost);
            transfer.Move(ref DiffuseBoost);
            return this;
        }
    }
}