namespace AssetTool
{
    public class FShaderMapContent : ITransferible
    {
        public virtual ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TShaderMap<ContentType, PointerTableType> : FShaderMapBase, ITransferible
        where ContentType : ITransferible, new() where PointerTableType : ITransferible, new()
    {
        public override ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FShaderMapBase : ITransferible
    {
        public virtual ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FShaderTypeDependency : ITransferible
    {
        public FHashedName ShaderTypeName;
        public FSHAHash SourceHash;
        public int32 PermutationId;

        [Location("friend FArchive& operator<<(FArchive& Ar,class FShaderTypeDependency& Ref)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ShaderTypeName);
            transfer.Move(ref SourceHash);
            if (transfer.Supports.ShaderPermutationId)
            {
                transfer.Move(ref PermutationId);
            }
            return this;
        }
    }

    public class FShaderPipelineTypeDependency : ITransferible
    {
        public FHashedName ShaderPipelineTypeName;
        public FSHAHash StagesSourceHash;

        [Location("friend FArchive& operator<<(FArchive& Ar, class FShaderPipelineTypeDependency& Ref)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ShaderPipelineTypeName);
            transfer.Move(ref StagesSourceHash);
            return this;
        }
    }
}
