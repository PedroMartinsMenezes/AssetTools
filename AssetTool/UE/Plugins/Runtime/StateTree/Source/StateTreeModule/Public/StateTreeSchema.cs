namespace AssetTool
{
    [JsonAsset("StateTreeSchema")]
    public class UStateTreeSchema : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}