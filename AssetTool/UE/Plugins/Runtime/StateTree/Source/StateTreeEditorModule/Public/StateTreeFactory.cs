namespace AssetTool
{
    [JsonAsset("StateTreeFactory")]
    public class UStateTreeFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}