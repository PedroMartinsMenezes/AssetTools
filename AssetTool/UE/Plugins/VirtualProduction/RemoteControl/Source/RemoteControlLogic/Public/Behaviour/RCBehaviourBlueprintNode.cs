namespace AssetTool
{
    [JsonAsset("RCBehaviourBlueprintNode")]
    public class URCBehaviourBlueprintNode : URCBehaviourNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}