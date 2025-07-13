namespace AssetTool
{
    [JsonAsset("BasicOverlaysFactory")]
    public class UBasicOverlaysFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}