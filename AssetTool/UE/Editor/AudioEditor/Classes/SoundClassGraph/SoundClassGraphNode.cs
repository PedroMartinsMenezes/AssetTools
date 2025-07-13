namespace AssetTool
{
    [JsonAsset("SoundClassGraphNode")]
    public class USoundClassGraphNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}