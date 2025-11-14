namespace AssetTool
{
    [JsonAsset("AvaGameInstancePlayableGroup")]
    public class UAvaGameInstancePlayableGroup : UAvaPlayableGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}