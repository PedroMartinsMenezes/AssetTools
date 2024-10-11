namespace AssetTool
{
    public class TStaticMeshVertexData<T> : FStaticMeshVertexDataInterface, ITransferible where T : ITransferible
    {
        public List<T> Data;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            return this;
        }
    }
}
