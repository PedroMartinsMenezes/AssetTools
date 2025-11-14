namespace AssetTool
{
    public class FCompactMaps : ITransferable
    {
        public int32[] VertMap;
        public int32[] TriMap;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref VertMap);
            transfer.Move(ref TriMap);
            return this;
        }

        public bool VertexMapIsSet()
        {
            return VertMap.Length > 0;
        }

        public bool TriangleMapIsSet()
        {
            return TriMap.Length > 0;
        }
    }
}
