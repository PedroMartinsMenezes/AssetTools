namespace AssetTool
{
    [JsonAsset("MetaHumanPackageFactory")]
    public class UMetaHumanPackageFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}