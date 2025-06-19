namespace AssetTool
{
    public class FCompactMaps : ITransferible
    {
        public List<int32> VertMap;
        public List<int32> TriMap;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref VertMap);
            transfer.Move(ref TriMap);
            return this;
        }
    }
}
