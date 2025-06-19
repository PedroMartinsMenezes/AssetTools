namespace AssetTool
{
    [JsonAsset("Transactor")]
    public class UTransactor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}