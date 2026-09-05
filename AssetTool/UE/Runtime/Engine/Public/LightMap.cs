using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FLightMap2D), nameof(FLightMap2D))]
    [JsonDerivedType(typeof(FLegacyLightMap1D), nameof(FLegacyLightMap1D))]
    public class FLightMap : ITransferable
    {
        public FLightMapType LightMapType;
        public List<FGuid> LightGuids;
        public FLightMap R;

        [Location("FArchive& operator<<(FArchive& Ar, FLightMap*& R)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref LightMapType);
            switch (LightMapType)
            {
                case FLightMapType.LMT_1D:
                    R ??= new FLegacyLightMap1D();
                    break;
                case FLightMapType.LMT_2D:
                    R ??= new FLightMap2D();
                    break;
            }
            if (R != default)
            {
                R.Serialize(transfer);
            }
            return this;
        }

        [Location("void FLightMap::Serialize(FArchive& Ar)")]
        public virtual ITransferable Serialize(Transfer transfer)
        {
            transfer.Move(ref LightGuids);
            return this;
        }
    }

    public class FLightMap2D : FLightMap
    {
        public List<FLightMap2DDummy> Dummy;
        public TUInt32[] Textures = [new(), new()];
        public UInt32 SkyOcclusionTexture;
        public UInt32 AOMaterialMaskTexture;
        public FVector4f[] ScaleVectors = new FVector4f[Consts.NUM_STORED_LIGHTMAP_COEF];
        public FVector4f[] AddVectors = new FVector4f[Consts.NUM_STORED_LIGHTMAP_COEF];
        public FVector2D CoordinateScale;
        public FVector2D CoordinateBias;
        public bool[] bShadowChannelValid = [new(), new(), new(), new()];
        public FVector4f InvUniformPenumbraSize;
        public UInt32[] Dummies2D;
        public UInt32[] Dummies1D;

        [Location("void FLightMap2D::Serialize(FArchive& Ar)")]
        public override ITransferable Serialize(Transfer transfer)
        {
            base.Serialize(transfer);
            if (!transfer.Supports.VER_UE4_LOW_QUALITY_DIRECTIONAL_LIGHTMAPS)
            {
                transfer.Move(ref Dummy, 3);
            }
            else if (!transfer.Supports.VER_UE4_COMBINED_LIGHTMAP_TEXTURES)
            {
                transfer.Move(ref Dummy, 4);
            }
            else
            {
                transfer.Move(ref Textures, Textures.Length);

                if (transfer.Supports.VER_UE4_SKY_LIGHT_COMPONENT)
                {
                    transfer.Move(ref SkyOcclusionTexture);
                    if (transfer.Supports.VER_UE4_AO_MATERIAL_MASK)
                    {
                        transfer.Move(ref AOMaterialMaskTexture);
                    }
                }

                for (int i = 0; i < Consts.NUM_STORED_LIGHTMAP_COEF; i++)
                {
                    transfer.Move(ref ScaleVectors[i]);
                    transfer.Move(ref AddVectors[i]);
                }
            }

            transfer.Move(ref CoordinateScale);
            transfer.Move(ref CoordinateBias);

            if (transfer.Supports.LightmapHasShadowmapData)
            {
                transfer.Move(ref bShadowChannelValid, bShadowChannelValid.Length);
                transfer.Move(ref InvUniformPenumbraSize);
            }
            if (transfer.Supports.VirtualTexturedLightmaps)
            {
                if (transfer.Supports.VirtualTexturedLightmapsV2)
                {
                    if (transfer.Supports.VirtualTexturedLightmapsV3)
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

        public class FLightMap2DDummy : ITransferable
        {
            public ULightMapTexture2D dummy1;
            public FVector4 dummy2;
            public FVector4 dummy3;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref dummy1);
                transfer.Move(ref dummy2);
                transfer.Move(ref dummy3);
                return this;
            }
        }
    }

    public enum FLightMapType : UInt32
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

        public FVector[] Dummy = new FVector[5];

        [Location("void FLegacyLightMap1D::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            Owner.Move(transfer);

            throw new NotImplementedException();

            ///DirectionalSamples.Serialize( Ar, Owner, INDEX_NONE, false );

            ///transfer.Move(ref Dummy, Dummy.Length);

            ///SimpleSamples.Serialize( Ar, Owner, INDEX_NONE, false );

            ///return this;
        }
    }
}
