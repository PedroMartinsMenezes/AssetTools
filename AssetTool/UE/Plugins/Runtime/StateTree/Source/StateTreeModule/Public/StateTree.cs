namespace AssetTool
{
    [JsonAsset("StateTree")]
    public class UStateTree : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}