namespace AssetTool
{
    [JsonAsset("AvaRemoteProxyPlayableGroup")]
    public class UAvaRemoteProxyPlayableGroup : UAvaPlayableGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}