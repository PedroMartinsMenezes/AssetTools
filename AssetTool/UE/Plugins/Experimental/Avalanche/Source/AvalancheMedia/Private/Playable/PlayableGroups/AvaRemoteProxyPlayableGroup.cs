namespace AssetTool
{
    [JsonAsset("AvaRemoteProxyPlayableGroup")]
    public class UAvaRemoteProxyPlayableGroup : UAvaPlayableGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}