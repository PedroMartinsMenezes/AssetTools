namespace AssetTool
{
    [JsonAsset("AvaGameViewportPlayableGroup")]
    public class UAvaGameViewportPlayableGroup : UAvaPlayableGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}