namespace AssetTool
{
    [JsonAsset("CookOnTheFlyServer")]
    public class UCookOnTheFlyServer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}