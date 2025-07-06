namespace AssetTool
{
    public class FMaterial : ITransferible
    {
        public FBool bCooked;
        public FBool bValid;
        public FMaterialShaderMap LoadedShaderMap;

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
    }

    public class FMaterialResource : FMaterial, ITransferible
    {
        public override ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
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
}
