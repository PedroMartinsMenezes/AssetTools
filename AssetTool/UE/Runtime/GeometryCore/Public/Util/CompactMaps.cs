namespace AssetTool
{
    public class FCompactMaps : ITransferible
    {
        public int32[] VertMap;
        public int32[] TriMap;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref VertMap);
            transfer.Move(ref TriMap);
            return this;
        }
    }
}
