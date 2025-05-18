namespace AssetTool
{
    [JsonAsset("StateTree")]
    public class UStateTree : UDataAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}