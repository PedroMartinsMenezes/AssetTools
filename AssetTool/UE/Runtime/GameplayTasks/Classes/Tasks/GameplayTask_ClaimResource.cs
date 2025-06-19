namespace AssetTool
{
    [JsonAsset("GameplayTask_ClaimResource")]
    public class UGameplayTask_ClaimResource : UGameplayTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}