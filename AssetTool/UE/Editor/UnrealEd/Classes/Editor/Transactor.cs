namespace AssetTool
{
    [JsonAsset("Transactor")]
    public class UTransactor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}