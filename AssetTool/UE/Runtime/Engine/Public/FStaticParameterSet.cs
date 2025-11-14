namespace AssetTool
{
    public class FStaticParameterSet : ITransferable
    {
        public List<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED;
        public List<FStaticComponentMaskParameter> StaticComponentMaskParameters;
        public List<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
        public List<FStaticMaterialLayersParameter> MaterialLayersParameters_DEPRECATED;

        [Location("void FStaticParameterSet::SerializeLegacy(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref StaticSwitchParameters_DEPRECATED);
            transfer.Move(ref StaticComponentMaskParameters);
            transfer.Move(ref TerrainLayerWeightParameters);
            if (transfer.Supports.MaterialLayersParameterSerializationRefactor)
            {
                if (!transfer.Supports.MaterialLayerStacksAreNotParameters)
                {
                    transfer.Move(ref MaterialLayersParameters_DEPRECATED);
                }
            }
            return this;
        }

        public class FStaticSwitchParameter : FStaticParameterBase, ITransferable
        {
            public FBool Value;

            public ITransferable Move(Transfer transfer)
            {
                if (!transfer.Supports.MaterialAttributeLayerParameters)
                {
                    ParameterInfo ??= new();
                    transfer.Move(ref ParameterInfo.Name);
                }
                else
                {
                    transfer.Move(ref ParameterInfo);
                }
                transfer.Move(ref Value);
                transfer.Move(ref bOverride);
                transfer.Move(ref ExpressionGUID);
                return this;
            }
        }

        public class FStaticComponentMaskParameter : FStaticParameterBase, ITransferable
        {
            public FBool R;
            public FBool G;
            public FBool B;
            public FBool A;

            public ITransferable Move(Transfer transfer)
            {
                if (!transfer.Supports.MaterialAttributeLayerParameters)
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
            public FMaterialParameterInfo ParameterInfo;
            public FBool bOverride;
            public FGuid ExpressionGUID;
        }

        public class FStaticTerrainLayerWeightParameter : ITransferable
        {
            public FMaterialParameterInfo ParameterInfo_DEPRECATED;
            public FName LayerName;
            public FBool bWeightBasedBlend;
            public Int32 WeightmapIndex;
            public FBool bOverride_DEPRECATED;
            public FGuid ExpressionGUID_DEPRECATED;

            public ITransferable Move(Transfer transfer)
            {
                if (!transfer.Supports.MaterialAttributeLayerParameters)
                {
                    transfer.Move(ref LayerName);
                }
                else if (!transfer.Supports.TerrainLayerWeightsAreNotParameters)
                {
                    ParameterInfo_DEPRECATED ??= new();
                    ParameterInfo_DEPRECATED.Move(transfer);
                }
                else
                {
                    transfer.Move(ref LayerName);
                }

                if (transfer.Supports.StaticParameterTerrainLayerWeightBlendType)
                {
                    transfer.Move(ref bWeightBasedBlend);
                }

                transfer.Move(ref WeightmapIndex);

                if (!transfer.Supports.TerrainLayerWeightsAreNotParameters
                    )
                {
                    transfer.Move(ref bOverride_DEPRECATED);
                    transfer.Move(ref ExpressionGUID_DEPRECATED);
                }
                return this;
            }
        }

        public class FStaticMaterialLayersParameter : FStaticParameterBase, ITransferable
        {
            public FMaterialLayersFunctions Value;

            [Location("friend FArchive& operator<<(FArchive& Ar, FStaticMaterialLayersParameter& P)")]
            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref ParameterInfo);
                transfer.Move(ref bOverride);
                transfer.Move(ref ExpressionGUID);

                if (transfer.Supports.MaterialLayersParameterSerializationRefactor)
                {
                    transfer.Move(ref Value);
                }
                return this;
            }
        }
    }
}
