namespace AssetTool
{
    [JsonAsset("AvaPlayableRemoteTransition")]
    public class UAvaPlayableRemoteTransition : UAvaPlayableTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}