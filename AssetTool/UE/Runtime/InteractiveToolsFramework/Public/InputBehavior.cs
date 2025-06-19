namespace AssetTool
{
    [JsonAsset("InputBehavior")]
    public class UInputBehavior : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}