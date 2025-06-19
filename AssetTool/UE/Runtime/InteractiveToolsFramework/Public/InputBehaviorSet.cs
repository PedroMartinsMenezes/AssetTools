namespace AssetTool
{
    [JsonAsset("InputBehaviorSet")]
    public class UInputBehaviorSet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalInputBehaviorSource")]
    public class ULocalInputBehaviorSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}