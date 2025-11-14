namespace AssetTool
{
    [JsonAsset("AnimGraphNodeBinding_Base")]
    public class UAnimGraphNodeBinding_Base : UAnimGraphNodeBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}