namespace AssetTool
{
    [JsonAsset("AvaTransitionTree")]
    public class UAvaTransitionTree : UStateTree
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}