namespace AssetTool
{
    [JsonAsset("RCBehaviourBindNode")]
    public class URCBehaviourBindNode : URCBehaviourNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}