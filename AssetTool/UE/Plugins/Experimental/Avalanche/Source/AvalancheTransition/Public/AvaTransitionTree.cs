namespace AssetTool
{
    [JsonAsset("AvaTransitionTree")]
    public class UAvaTransitionTree : UStateTree
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}