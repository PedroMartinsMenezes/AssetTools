namespace AssetTool
{
    [JsonAsset("SoundCueGraphNode_Base")]
    public class USoundCueGraphNode_Base : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}