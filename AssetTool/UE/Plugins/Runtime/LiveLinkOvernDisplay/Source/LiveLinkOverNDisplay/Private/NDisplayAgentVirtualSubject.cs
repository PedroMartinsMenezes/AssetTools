namespace AssetTool
{
    [JsonAsset("NDisplayAgentVirtualSubject")]
    public class UNDisplayAgentVirtualSubject : ULiveLinkVirtualSubject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}