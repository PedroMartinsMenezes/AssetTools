namespace AssetTool
{
    [JsonAsset("AvaGameInstancePlayableGroup")]
    public class UAvaGameInstancePlayableGroup : UAvaPlayableGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}