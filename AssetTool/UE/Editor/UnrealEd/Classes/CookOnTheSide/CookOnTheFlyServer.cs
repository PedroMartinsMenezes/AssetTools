namespace AssetTool
{
    [JsonAsset("CookOnTheFlyServer")]
    public class UCookOnTheFlyServer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}