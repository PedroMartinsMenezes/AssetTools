namespace AssetTool
{
    public class FSkinWeightVertexBuffer : ITransferible
    {
        public FSkinWeightDataVertexBuffer DataVertexBuffer;
        public FSkinWeightLookupVertexBuffer LookupVertexBuffer;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref DataVertexBuffer);
            if (!transfer.Supports.UnlimitedBoneInfluences)
            {
                transfer.Move(ref LookupVertexBuffer);
            }
            return this;
        }
    }

    public class FSkinWeightDataVertexBuffer : FVertexBuffer, ITransferible
    {
        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FSkinWeightLookupVertexBuffer : FVertexBuffer, ITransferible
    {
        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
