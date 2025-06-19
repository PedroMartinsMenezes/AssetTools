namespace AssetTool
{
    [JsonAsset("StateTree")]
    public class UStateTree : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}