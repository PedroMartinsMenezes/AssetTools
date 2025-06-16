namespace AssetTool
{
    [JsonAsset("Transactor")]
    public class UTransactor : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}