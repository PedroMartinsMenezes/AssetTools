namespace AssetTool
{
    [JsonAsset("StateTreeSchema")]
    public class UStateTreeSchema : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}