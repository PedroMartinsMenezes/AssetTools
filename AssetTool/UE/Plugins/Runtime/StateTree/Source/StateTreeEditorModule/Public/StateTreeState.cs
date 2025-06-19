namespace AssetTool
{
    [JsonAsset("StateTreeState")]
    public class UStateTreeState : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}