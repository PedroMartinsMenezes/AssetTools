namespace AssetTool
{
    public class FShaderMapContent : ITransferable
    {
        public virtual ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TShaderMap<ContentType, PointerTableType> : FShaderMapBase, ITransferable
        where ContentType : ITransferable, new() where PointerTableType : ITransferable, new()
    {
        public override ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FShaderMapBase : ITransferable
    {
        public virtual ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FShaderTypeDependency : ITransferable
    {
        public FHashedName ShaderTypeName;
        public FSHAHash SourceHash;
        public int32 PermutationId;

        [Location("friend FArchive& operator<<(FArchive& Ar,class FShaderTypeDependency& Ref)")]
        public ITransferable Move(Transfer transfer)
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

    public class FShaderPipelineTypeDependency : ITransferable
    {
        public FHashedName ShaderPipelineTypeName;
        public FSHAHash StagesSourceHash;

        [Location("friend FArchive& operator<<(FArchive& Ar, class FShaderPipelineTypeDependency& Ref)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ShaderPipelineTypeName);
            transfer.Move(ref StagesSourceHash);
            return this;
        }
    }
}
