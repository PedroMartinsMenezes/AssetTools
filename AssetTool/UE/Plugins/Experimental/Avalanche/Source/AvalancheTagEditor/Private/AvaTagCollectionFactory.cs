namespace AssetTool
{
    [JsonAsset("AvaTagCollectionFactory")]
    public class UAvaTagCollectionFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}