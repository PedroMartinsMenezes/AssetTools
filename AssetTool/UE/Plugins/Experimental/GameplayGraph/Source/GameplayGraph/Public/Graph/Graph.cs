namespace AssetTool
{
    [JsonAsset("Graph")]
    public class UGraph : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}