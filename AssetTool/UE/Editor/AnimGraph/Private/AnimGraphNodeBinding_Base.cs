namespace AssetTool
{
    [JsonAsset("AnimGraphNodeBinding_Base")]
    public class UAnimGraphNodeBinding_Base : UAnimGraphNodeBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}