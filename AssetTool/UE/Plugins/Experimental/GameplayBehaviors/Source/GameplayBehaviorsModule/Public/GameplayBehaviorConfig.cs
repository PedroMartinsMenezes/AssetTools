namespace AssetTool
{
    [JsonAsset("GameplayBehaviorConfig")]
    public class UGameplayBehaviorConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}