using static AssetTool.FStaticParameterSet;

namespace AssetTool
{
    public class FMaterial : ITransferable
    {
        public FBool bCooked;
        public FBool bValid;
        public FMaterialShaderMap LoadedShaderMap;

        #region Legacy
        public List<FString> LegacyStrings;
        public Dictionary<TInt32, TInt32> LegacyMap;
        public int32? LegacyInt;
        public FGuid? Id_DEPRECATED;
        public List<FObjectPtr> LegacyTextures;
        public bool? bTemp1;
        public bool? bTemp2;
        public List<FLegacyTextureLookup> LegacyLookups;
        public uint32? DummyDroppedFallbackComponents;
        #endregion

        public virtual ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        [Location("void FMaterial::SerializeInlineShaderMap(FArchive& Ar, const FName& SerializingAsset)")]
        public void SerializeInlineShaderMap(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            if (bCooked)
            {
                transfer.Move(ref bValid);
                if (bValid)
                {
                    transfer.Move(ref LoadedShaderMap);
                }
            }
        }

        [Location("void FMaterial::LegacySerialize(FArchive& Ar)")]
        public virtual void LegacySerialize(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                transfer.Move(ref LegacyStrings);
                transfer.Move(ref LegacyMap);
                transfer.Move(ref LegacyInt);
                transfer.Move(ref Id_DEPRECATED);
                transfer.Move(ref LegacyTextures);
                transfer.Move(ref bTemp1);
                transfer.Move(ref bTemp2);
                transfer.Move(ref LegacyLookups);
                transfer.Move(ref DummyDroppedFallbackComponents);
            }
            SerializeInlineShaderMap(transfer);
        }
    }

    public class FMaterialResource : FMaterial, ITransferable
    {
        public int32? BlendModeOverrideValueTemp;
        public bool? bDummyBool1;
        public bool? bDummyBool2;

        [Location("void FMaterialResource::LegacySerialize(FArchive& Ar)")]
        public override void LegacySerialize(Transfer transfer)
        {
            base.LegacySerialize(transfer);
            if (!transfer.Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                transfer.Move(ref BlendModeOverrideValueTemp);
                transfer.Move(ref bDummyBool1);
                transfer.Move(ref bDummyBool2);
            }
        }
    }

    [Location("class FMaterialShaderMap : public TShaderMap<FMaterialShaderMapContent, FShaderMapPointerTable>")]
    public class FMaterialShaderMap : TShaderMap<FMaterialShaderMapContent, FShaderMapPointerTable>, ITransferable
    {
        public FMaterialShaderMapId ShaderMapId;

        [Location("bool FMaterialShaderMap::Serialize(FShaderSerializeContext& Ctx)")]
        public override ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ShaderMapId);

            return this;
        }
    }

    public class FMaterialShaderMapId : ITransferable
    {
        public EMaterialShaderMapUsage Usage;
        public FString UsageCustomOutput;
        public FGuid BaseMaterialId;
        public uint8? QualityLevel;
        public int32? FeatureLevel;
        public uint8? LegacyQualityLevel;
        public FStaticParameterSet ParameterSet;
        public List<FStaticSwitchParameter> StaticSwitchParameters;
        public List<FStaticComponentMaskParameter> StaticComponentMaskParameters;
        public List<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
        public TOptional<FMaterialLayersFunctionsID> MaterialLayersId;
        public List<FGuid> ReferencedFunctions;
        public List<FGuid> ReferencedParameterCollections;
        public List<FGuid> Deprecated;
        public List<FShaderTypeDependency> ShaderTypeDependencies;
        public List<FShaderPipelineTypeDependency> ShaderPipelineTypeDependencies;
        public List<FVertexFactoryTypeDependency> VertexFactoryTypeDependencies;
        public FSHAHash TextureReferencesHash;
        public FSHAHash LegacyHash;
        public FSHAHash ExpressionIncludesHash;
        public FSHAHash BasePropertyOverridesHash;
        public bool? bUsingNewHLSLGenerator;
        public FSHAHash ExternalCodeReferencesHash;

        [Location("void FMaterialShaderMapId::Serialize(FArchive& Ar, bool bLoadingCooked)")]
        public ITransferable Move(Transfer transfer)
        {
            bool bIsLegacyPackage = !transfer.Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS;
            transfer.MoveEnum(ref Usage);
            if (Usage == EMaterialShaderMapUsage.MaterialExportCustomOutput)
            {
                transfer.Move(ref UsageCustomOutput);
            }
            transfer.Move(ref BaseMaterialId);
            if (!bIsLegacyPackage)
            {
                transfer.Move(ref QualityLevel);
                transfer.Move(ref FeatureLevel);
            }
            else
            {
                transfer.Move(ref LegacyQualityLevel);
            }
            if (!transfer.Supports.MaterialShaderMapIdSerialization)
            {
                transfer.Move(ref ParameterSet);
            }
            else
            {
                transfer.Move(ref StaticSwitchParameters);
                transfer.Move(ref StaticComponentMaskParameters);
                transfer.Move(ref TerrainLayerWeightParameters);
                if (transfer.Supports.MaterialLayerStacksAreNotParameters)
                {
                    transfer.Move(ref MaterialLayersId);
                }
            }
            transfer.Move(ref ReferencedFunctions);
            if (transfer.Supports.VER_UE4_COLLECTIONS_IN_SHADERMAPID)
            {
                transfer.Move(ref ReferencedParameterCollections);
            }
            if (transfer.Supports.AddedMaterialSharedInputs && !transfer.Supports.RemovedMaterialSharedInputCollection)
            {
                transfer.Move(ref Deprecated);
            }
            transfer.Move(ref ShaderTypeDependencies);
            if (!bIsLegacyPackage)
            {
                transfer.Move(ref ShaderPipelineTypeDependencies);
            }
            transfer.Move(ref VertexFactoryTypeDependencies);
            if (!bIsLegacyPackage)
            {
                transfer.Move(ref TextureReferencesHash);
            }
            else
            {
                transfer.Move(ref LegacyHash);
            }
            if (transfer.Supports.AddedMaterialExpressionIncludesHash)
            {
                transfer.Move(ref ExpressionIncludesHash);
            }
            if (transfer.Supports.VER_UE4_MATERIAL_INSTANCE_BASE_PROPERTY_OVERRIDES)
            {
                transfer.Move(ref BasePropertyOverridesHash);
            }
            if (!bIsLegacyPackage)
            {
                transfer.Move(ref bUsingNewHLSLGenerator);
                transfer.Move(ref ExternalCodeReferencesHash);
            }
            return this;
        }
    }

    public class FMaterialShaderMapContent : FShaderMapContent, ITransferable
    {
        public override ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FShaderMapPointerTable : FPointerTableBase, ITransferable
    {
        public override ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public struct FLegacyTextureLookup : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TexCoordIndex);
            transfer.Move(ref TextureIndex);
            transfer.Move(ref UScale);
            transfer.Move(ref VScale);
            return this;
        }

        public int32 TexCoordIndex;
        public int32 TextureIndex;
        public float UScale;
        public float VScale;
    }

    public enum EMaterialShaderMapUsage : uint32
    {
        Default,
        LightmassExportEmissive,
        LightmassExportDiffuse,
        LightmassExportOpacity,
        LightmassExportNormal,
        MaterialExportBaseColor,
        MaterialExportSpecular,
        MaterialExportNormal,
        MaterialExportTangent,
        MaterialExportMetallic,
        MaterialExportRoughness,
        MaterialExportAnisotropy,
        MaterialExportAO,
        MaterialExportEmissive,
        MaterialExportOpacity,
        MaterialExportOpacityMask,
        MaterialExportSubSurfaceColor,
        MaterialExportClearCoat,
        MaterialExportClearCoatRoughness,
        MaterialExportCustomOutput,
        MaterialExportShadingModel,
        MaterialExportRefraction,
    }
}
