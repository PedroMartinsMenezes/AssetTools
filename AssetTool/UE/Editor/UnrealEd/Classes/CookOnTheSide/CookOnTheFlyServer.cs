namespace AssetTool
{
    [JsonAsset("CookOnTheFlyServer")]
    public class UCookOnTheFlyServer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}