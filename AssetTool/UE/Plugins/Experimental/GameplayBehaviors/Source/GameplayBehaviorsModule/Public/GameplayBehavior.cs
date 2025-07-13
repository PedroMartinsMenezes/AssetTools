namespace AssetTool
{
    [JsonAsset("GameplayBehavior")]
    public class UGameplayBehavior : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}