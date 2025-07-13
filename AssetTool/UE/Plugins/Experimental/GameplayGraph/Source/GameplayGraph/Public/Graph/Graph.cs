namespace AssetTool
{
    [JsonAsset("Graph")]
    public class UGraph : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}