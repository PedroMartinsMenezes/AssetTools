namespace AssetTool
{
    [JsonAsset("AvaPlayableRemoteTransition")]
    public class UAvaPlayableRemoteTransition : UAvaPlayableTransition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}