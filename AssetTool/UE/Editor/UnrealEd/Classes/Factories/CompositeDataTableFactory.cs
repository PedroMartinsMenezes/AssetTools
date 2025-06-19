namespace AssetTool
{
    [JsonAsset("CompositeDataTableFactory")]
    public class UCompositeDataTableFactory : UDataTableFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}