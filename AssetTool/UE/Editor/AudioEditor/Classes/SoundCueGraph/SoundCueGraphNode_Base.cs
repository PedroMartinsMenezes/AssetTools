namespace AssetTool
{
    [JsonAsset("SoundCueGraphNode_Base")]
    public class USoundCueGraphNode_Base : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}