namespace AssetTool
{
    [JsonAsset("InputBehaviorSet")]
    public class UInputBehaviorSet : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalInputBehaviorSource")]
    public class ULocalInputBehaviorSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}