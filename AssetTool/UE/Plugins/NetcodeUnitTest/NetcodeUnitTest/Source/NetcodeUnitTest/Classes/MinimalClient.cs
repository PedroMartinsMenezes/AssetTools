namespace AssetTool
{
    [JsonAsset("MinimalClient")]
    public class UMinimalClient : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}