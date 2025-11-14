namespace AssetTool
{
    [JsonAsset("RCBehaviourNode")]
    public class URCBehaviourNode : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}