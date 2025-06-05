namespace AssetTool
{
    [JsonAsset("AvaGameInstancePlayableGroup")]
    public class UAvaGameInstancePlayableGroup : UAvaPlayableGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}