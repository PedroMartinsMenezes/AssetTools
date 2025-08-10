namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityAssetEditor")]
    public class UMetaHumanIdentityAssetEditor : UAssetEditor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}