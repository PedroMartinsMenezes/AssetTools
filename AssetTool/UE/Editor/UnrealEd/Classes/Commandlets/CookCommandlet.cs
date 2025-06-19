namespace AssetTool
{
    [JsonAsset("CookCommandlet")]
    public class UCookCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}