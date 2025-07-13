namespace AssetTool
{
    [JsonAsset("ReimportBasicOverlaysFactory")]
    public class UReimportBasicOverlaysFactory : UBasicOverlaysFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}