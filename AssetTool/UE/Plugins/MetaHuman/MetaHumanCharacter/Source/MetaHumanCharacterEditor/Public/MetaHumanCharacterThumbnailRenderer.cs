namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterThumbnailRenderer")]
    public class UMetaHumanCharacterThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}