namespace AssetTool
{
    [JsonAsset("FilteredResults")]
    public class UFilteredResults : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}