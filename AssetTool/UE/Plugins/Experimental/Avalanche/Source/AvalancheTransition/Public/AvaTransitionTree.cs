namespace AssetTool
{
    [JsonAsset("AvaTransitionTree")]
    public class UAvaTransitionTree : UStateTree
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}