namespace AssetTool
{
    [JsonAsset("AvaGameViewportPlayableGroup")]
    public class UAvaGameViewportPlayableGroup : UAvaPlayableGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}