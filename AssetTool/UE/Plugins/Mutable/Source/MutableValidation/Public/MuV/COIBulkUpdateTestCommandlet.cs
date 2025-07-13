namespace AssetTool
{
    [JsonAsset("COIBulkUpdateTestCommandlet")]
    public class UCOIBulkUpdateTestCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}