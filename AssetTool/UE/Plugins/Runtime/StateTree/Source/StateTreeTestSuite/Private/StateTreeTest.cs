namespace AssetTool
{
    [JsonAsset("StateTreeTestSchema")]
    public class UStateTreeTestSchema : UStateTreeSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}