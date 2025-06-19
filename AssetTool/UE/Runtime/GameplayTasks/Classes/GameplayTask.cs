namespace AssetTool
{
    [JsonAsset("GameplayTask")]
    public class UGameplayTask : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}