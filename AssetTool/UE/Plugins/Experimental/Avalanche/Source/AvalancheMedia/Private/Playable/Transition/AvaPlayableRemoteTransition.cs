namespace AssetTool
{
    [JsonAsset("AvaPlayableRemoteTransition")]
    public class UAvaPlayableRemoteTransition : UAvaPlayableTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}