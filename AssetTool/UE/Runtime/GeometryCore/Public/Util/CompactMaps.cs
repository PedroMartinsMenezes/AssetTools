namespace AssetTool
{
    public class FCompactMaps : ITransferible
    {
        public List<int32> VertMap;
        public List<int32> TriMap;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref VertMap);
            transfer.Move(ref TriMap);
            return this;
        }
    }
}
