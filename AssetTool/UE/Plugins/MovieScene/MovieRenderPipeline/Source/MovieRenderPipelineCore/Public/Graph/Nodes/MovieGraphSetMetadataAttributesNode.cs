namespace AssetTool
{
    [JsonAsset("MovieGraphMetadataAttributeCollection")]
    public class UMovieGraphMetadataAttributeCollection : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphSetMetadataAttributesNode")]
    public class UMovieGraphSetMetadataAttributesNode : UMovieGraphSettingNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}