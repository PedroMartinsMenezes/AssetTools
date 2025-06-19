namespace AssetTool
{
    [JsonAsset("GameplayTaskResource")]
    public class UGameplayTaskResource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}