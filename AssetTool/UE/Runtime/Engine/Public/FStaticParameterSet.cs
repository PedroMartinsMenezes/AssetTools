namespace AssetTool
{
    public class FStaticParameterSet
    {
        public List<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED = [];
        public List<FStaticComponentMaskParameter> StaticComponentMaskParameters = [];
        public List<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters = [];
        public List<FStaticMaterialLayersParameter> MaterialLayersParameters_DEPRECATED;

        [Location("void FStaticParameterSet::SerializeLegacy(FArchive& Ar)")]
        public void Move(Transfer transfer)
        {
            StaticSwitchParameters_DEPRECATED.Resize(transfer);
            StaticSwitchParameters_DEPRECATED.ForEach(x => x.Move(transfer));

            StaticComponentMaskParameters.Resize(transfer);
            StaticComponentMaskParameters.ForEach(x => x.Move(transfer));

            TerrainLayerWeightParameters.Resize(transfer);
            TerrainLayerWeightParameters.ForEach(x => x.Move(transfer));

            if (Supports.CustomVer(FReleaseObjectVersion.Enums.MaterialLayersParameterSerializationRefactor))
            {
                if (!Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.MaterialLayerStacksAreNotParameters))
                {
                    MaterialLayersParameters_DEPRECATED ??= new();
                    MaterialLayersParameters_DEPRECATED.Resize(transfer);
                    MaterialLayersParameters_DEPRECATED.ForEach(x => x.Move(transfer));
                }
            }
        }

        public class FStaticSwitchParameter : FStaticParameterBase
        {
            public void Move(Transfer transfer)
            {
                if (!Supports.CustomVer(FRenderingObjectVersion.Enums.MaterialAttributeLayerParameters))
                {
                    transfer.Move(ref ParameterInfo.Name);
                }
                else
                {
                    ParameterInfo.Move(transfer);
                }
            }
        }

        public class FStaticComponentMaskParameter : FStaticParameterBase
        {
            public FBool R;
            public FBool G;
            public FBool B;
            public FBool A;

            public void Move(Transfer transfer)
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
            }
        }

        public class FStaticParameterBase
        {
            public FMaterialParameterInfo ParameterInfo = new();
            public FBool bOverride;
            public FGuid ExpressionGUID;
        }

        public class FStaticTerrainLayerWeightParameter
        {
            public FMaterialParameterInfo ParameterInfo_DEPRECATED;
            public FName LayerName;
            public FBool bWeightBasedBlend;
            public Int32 WeightmapIndex;
            public FBool bOverride_DEPRECATED;
            public FGuid ExpressionGUID_DEPRECATED;

            public void Move(Transfer transfer)
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
            }
        }

        public class FStaticMaterialLayersParameter : FStaticParameterBase
        {
            public FMaterialLayersFunctions Value;

            public void Move(Transfer transfer)
            {
                ParameterInfo.Move(transfer);
                transfer.Move(ref bOverride);
                transfer.Move(ref ExpressionGUID);

                if (Supports.CustomVer(FReleaseObjectVersion.Enums.MaterialLayersParameterSerializationRefactor))
                {
                    ///P.Value.SerializeLegacy(Ar);
                    throw new NotImplementedException();
                }
            }
        }
    }
}
