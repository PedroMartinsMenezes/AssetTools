namespace AssetTool
{
    [JsonAsset("AnimGraphNode_AssetPlayerBase")]
    public class UAnimGraphNode_AssetPlayerBase : UAnimGraphNode_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}