namespace AssetTool
{
    public class FMaterialInstanceBasePropertyOverrides
    {
        public FBool bOverride_OpacityMaskClipValue;
        public float OpacityMaskClipValue;
        public FBool bOverride_BlendMode;
        public EBlendMode BlendMode;
        public FBool bOverride_ShadingModel;
        public EMaterialShadingModel ShadingModel;
        public FBool bOverride_TwoSided;
        public FBool TwoSided;
        public FBool bOverride_bIsThinSurface;
        public FBool bIsThinSurface;
        public FBool bOverride_DitheredLODTransition;
        public FBool DitheredLODTransition;

        public void Move(Transfer transfer)
        {
            transfer.Move(ref bOverride_OpacityMaskClipValue);
            transfer.Move(ref OpacityMaskClipValue);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MATERIAL_INSTANCE_BASE_PROPERTY_OVERRIDES_PHASE_2))
            {
                transfer.Move(ref bOverride_BlendMode);
                BlendMode = (EBlendMode)transfer.Move((byte)BlendMode);
                transfer.Move(ref bOverride_ShadingModel);
                ShadingModel = (EMaterialShadingModel)transfer.Move((byte)ShadingModel);
                transfer.Move(ref bOverride_TwoSided);
                transfer.Move(ref TwoSided);
                if (Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.MaterialInstanceBasePropertyOverridesThinSurface))
                {
                    transfer.Move(ref bOverride_bIsThinSurface);
                    transfer.Move(ref bIsThinSurface);
                }
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MATERIAL_INSTANCE_BASE_PROPERTY_OVERRIDES_DITHERED_LOD_TRANSITION))
                {
                    transfer.Move(ref bOverride_DitheredLODTransition);
                    transfer.Move(ref DitheredLODTransition);
                }
            }
        }
    }

    public enum EBlendMode : byte
    {
        BLEND_Opaque,
        BLEND_Masked,
        BLEND_Translucent,
        BLEND_Additive,
        BLEND_Modulate,
        BLEND_AlphaComposite,
        BLEND_AlphaHoldout,
        BLEND_TranslucentColoredTransmittance,
        BLEND_MAX,
        BLEND_TranslucentGreyTransmittance = BLEND_Translucent,
        BLEND_ColoredTransmittanceOnly = BLEND_Modulate
    }

    public enum EMaterialShadingModel
    {
        MSM_Unlit,
        MSM_DefaultLit,
        MSM_Subsurface,
        MSM_PreintegratedSkin,
        MSM_ClearCoat,
        MSM_SubsurfaceProfile,
        MSM_TwoSidedFoliage,
        MSM_Hair,
        MSM_Cloth,
        MSM_Eye,
        MSM_SingleLayerWater,
        MSM_ThinTranslucent,
        MSM_Strata,
        MSM_NUM,
        MSM_FromMaterialExpression,
        MSM_MAX
    }
}
