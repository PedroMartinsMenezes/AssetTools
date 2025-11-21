namespace AssetTool
{
    [JsonAsset("EdGraph")]
    public class UEdGraph : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public List<int> Nodes()
        {
            return Members["obj[] 'Nodes'"].ToString().Split(' ').Select(int.Parse).ToList();
        }
    }
}