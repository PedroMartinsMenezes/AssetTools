using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FLightMap2D), "FLightMap2D")]
    [JsonDerivedType(typeof(FLegacyLightMap1D), "FLegacyLightMap1D")]
    public class FLightMap : ITransferible
    {
        public FLightMapType LightMapType;
        public List<FGuid> LightGuids;
        public FLightMap R;

        [Location("FArchive& operator<<(FArchive& Ar, FLightMap*& R)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            LightMapType = (FLightMapType)transfer.Move((UInt32)LightMapType);
            switch (LightMapType)
            {
                case FLightMapType.LMT_1D:
                    R ??= new FLegacyLightMap1D();
                    break;
                case FLightMapType.LMT_2D:
                    R ??= new FLightMap2D();
                    break;
            }
            if (R != null)
            {
                R.Serialize(transfer);
            }
            return this;
        }

        [Location("void FLightMap::Serialize(FArchive& Ar)")]
        public virtual ITransferible Serialize(Transfer transfer)
        {
            transfer.Move(ref LightGuids);
            return this;
        }
    }

    public class FLightMap2D : FLightMap
    {
        public List<FLightMap2DDummy> Dummy;
        public TUInt32[] Textures;
        public UInt32 SkyOcclusionTexture;
        public UInt32 AOMaterialMaskTexture;
        public FVector4f[] ScaleVectors = new FVector4f[Consts.NUM_STORED_LIGHTMAP_COEF];
        public FVector4f[] AddVectors = new FVector4f[Consts.NUM_STORED_LIGHTMAP_COEF];
        public FVector2D CoordinateScale;
        public FVector2D CoordinateBias;
        public FBool[] bShadowChannelValid = [new(), new(), new(), new()];
        public FVector4f InvUniformPenumbraSize;
        public UInt32[] Dummies2D;
        public UInt32[] Dummies1D;

        [Location("void FLightMap2D::Serialize(FArchive& Ar)")]
        public override ITransferible Serialize(Transfer transfer)
        {
            base.Serialize(transfer);
            if (!Supports.VER_UE4_LOW_QUALITY_DIRECTIONAL_LIGHTMAPS)
            {
                Dummy.Resize(transfer, 3);
                transfer.Move(ref Dummy);
            }
            else if (!Supports.VER_UE4_COMBINED_LIGHTMAP_TEXTURES)
            {
                Dummy.Resize(transfer, 4);
                transfer.Move(ref Dummy);
            }
            else
            {
                Textures ??= [new(), new()];
                transfer.Move(ref Textures);

                if (Supports.VER_UE4_SKY_LIGHT_COMPONENT)
                {
                    transfer.Move(ref SkyOcclusionTexture);
                    if (Supports.VER_UE4_AO_MATERIAL_MASK)
                    {
                        transfer.Move(ref AOMaterialMaskTexture);
                    }
                }

                Enumerable.Range(0, Consts.NUM_STORED_LIGHTMAP_COEF).ToList().ForEach(CoefficientIndex =>
                {
                    transfer.Move(ref ScaleVectors[CoefficientIndex]);
                    transfer.Move(ref AddVectors[CoefficientIndex]);
                });
            }

            transfer.Move(ref CoordinateScale);
            transfer.Move(ref CoordinateBias);

            if (Supports.LightmapHasShadowmapData)
            {
                transfer.Move(ref bShadowChannelValid);
                transfer.Move(ref InvUniformPenumbraSize);
            }
            if (Supports.VirtualTexturedLightmaps)
            {
                if (Supports.VirtualTexturedLightmapsV2)
                {
                    if (Supports.VirtualTexturedLightmapsV3)
                    {
                        transfer.Move(ref Dummies2D, 2);
                    }
                    else
                    {
                        transfer.Move(ref Dummies2D, 1);
                    }
                }
                else
                {
                    transfer.Move(ref Dummies1D, 1);
                }
            }

            return this;
        }

        public class FLightMap2DDummy : ITransferible
        {
            public ULightMapTexture2D dummy1;
            public FVector4 dummy2;
            public FVector4 dummy3;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref dummy1);
                transfer.Move(ref dummy2);
                transfer.Move(ref dummy3);
                return this;
            }
        }
    }

    public enum FLightMapType
    {
        LMT_None = 0,
        LMT_1D = 1,
        LMT_2D = 2,
    }

    public class FLegacyLightMap1D : FLightMap
    {
        public UObject Owner;
        ///public TQuantizedLightSampleBulkData<FQuantizedDirectionalLightSample> DirectionalSamples;
        ///public TQuantizedLightSampleBulkData<FQuantizedSimpleLightSample> SimpleSamples;

        public FVector[] Dummy = [null, null, null, null, null];

        [Location("void FLegacyLightMap1D::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            Owner ??= new();
            Owner.Move(transfer);

            throw new NotImplementedException();

            ///DirectionalSamples.Serialize( Ar, Owner, INDEX_NONE, false );

            transfer.Move(ref Dummy);

            ///SimpleSamples.Serialize( Ar, Owner, INDEX_NONE, false );

            return this;
        }
    }
}
