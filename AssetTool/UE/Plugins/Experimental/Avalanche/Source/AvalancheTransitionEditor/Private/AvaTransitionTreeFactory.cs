namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeFactory")]
    public class UAvaTransitionTreeFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}