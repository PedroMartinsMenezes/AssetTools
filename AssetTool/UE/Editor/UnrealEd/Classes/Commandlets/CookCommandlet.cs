namespace AssetTool
{
    [JsonAsset("CookCommandlet")]
    public class UCookCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}