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
}
