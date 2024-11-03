namespace AssetTool
{
    public class FStaticParameterSet
    {
        public List<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED;
        public List<FStaticComponentMaskParameter> StaticComponentMaskParameters;
        public List<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
        public List<FStaticMaterialLayersParameter> MaterialLayersParameters_DEPRECATED;

        [Location("void FStaticParameterSet::SerializeLegacy(FArchive& Ar)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref StaticSwitchParameters_DEPRECATED);
            transfer.Move(ref StaticComponentMaskParameters);
            transfer.Move(ref TerrainLayerWeightParameters);

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.MaterialLayersParameterSerializationRefactor))
            {
                if (!Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.MaterialLayerStacksAreNotParameters))
                {
                    transfer.Move(ref MaterialLayersParameters_DEPRECATED);
                }
            }
        }

        public class FStaticSwitchParameter : FStaticParameterBase, ITransferible
        {
            public ITransferible Move(Transfer transfer)
            {
                if (!Supports.CustomVer(FRenderingObjectVersion.Enums.MaterialAttributeLayerParameters))
                {
                    transfer.Move(ref ParameterInfo.Name);
                }
                else
                {
                    ParameterInfo.Move(transfer);
                }
                return this;
            }
        }

        public class FStaticComponentMaskParameter : FStaticParameterBase, ITransferible
        {
            public FBool R;
            public FBool G;
            public FBool B;
            public FBool A;

            public ITransferible Move(Transfer transfer)
            {
                if (!Supports.CustomVer(FRenderingObjectVersion.Enums.MaterialAttributeLayerParameters))
                {
                    transfer.Move(ref ParameterInfo.Name);
                }
                else
                {
                    ParameterInfo.Move(transfer);
                }
                transfer.Move(ref R);
                transfer.Move(ref G);
                transfer.Move(ref B);
                transfer.Move(ref A);
                transfer.Move(ref bOverride);
                transfer.Move(ref ExpressionGUID);
                return this;
            }
        }

        public class FStaticParameterBase
        {
            public FMaterialParameterInfo ParameterInfo = new();
            public FBool bOverride;
            public FGuid ExpressionGUID;
        }

        public class FStaticTerrainLayerWeightParameter : ITransferible
        {
            public FMaterialParameterInfo ParameterInfo_DEPRECATED;
            public FName LayerName;
            public FBool bWeightBasedBlend;
            public Int32 WeightmapIndex;
            public FBool bOverride_DEPRECATED;
            public FGuid ExpressionGUID_DEPRECATED;

            public ITransferible Move(Transfer transfer)
            {
                if (!Supports.CustomVer(FRenderingObjectVersion.Enums.MaterialAttributeLayerParameters))
                {
                    transfer.Move(ref LayerName);
                }
                else if (!Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.TerrainLayerWeightsAreNotParameters))
                {
                    ParameterInfo_DEPRECATED ??= new();
                    ParameterInfo_DEPRECATED.Move(transfer);
                }
                else
                {
                    transfer.Move(ref LayerName);
                }

                if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.StaticParameterTerrainLayerWeightBlendType))
                {
                    transfer.Move(ref bWeightBasedBlend);
                }

                transfer.Move(ref WeightmapIndex);

                if (!Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.TerrainLayerWeightsAreNotParameters))
                {
                    transfer.Move(ref bOverride_DEPRECATED);
                    transfer.Move(ref ExpressionGUID_DEPRECATED);
                }
                return this;
            }
        }

        public class FStaticMaterialLayersParameter : FStaticParameterBase, ITransferible
        {
            public FMaterialLayersFunctions Value;

            public ITransferible Move(Transfer transfer)
            {
                ParameterInfo.Move(transfer);
                transfer.Move(ref bOverride);
                transfer.Move(ref ExpressionGUID);

                if (Supports.CustomVer(FReleaseObjectVersion.Enums.MaterialLayersParameterSerializationRefactor))
                {
                    ///P.Value.SerializeLegacy(Ar);
                    throw new NotImplementedException();
                }
                return this;
            }
        }
    }
}
