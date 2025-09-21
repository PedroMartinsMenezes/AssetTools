namespace AssetTool
{
    public class FMaterial : ITransferible
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

        public virtual ITransferible Move(Transfer transfer)
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

    public class FMaterialResource : FMaterial, ITransferible
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
    public class FMaterialShaderMap : TShaderMap<FMaterialShaderMapContent, FShaderMapPointerTable>, ITransferible
    {
        public FMaterialShaderMapId ShaderMapId;

        [Location("bool FMaterialShaderMap::Serialize(FShaderSerializeContext& Ctx)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ShaderMapId);

            return this;
        }
    }

    public class FMaterialShaderMapId : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FMaterialShaderMapContent : FShaderMapContent, ITransferible
    {
        public override ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FShaderMapPointerTable : FPointerTableBase, ITransferible
    {
        public override ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public struct FLegacyTextureLookup : ITransferible
    {
        public ITransferible Move(Transfer transfer)
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
    };
}
