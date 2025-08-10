namespace AssetTool
{
    [JsonAsset("MetaHumanConfigFactory")]
    public class UMetaHumanConfigFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}