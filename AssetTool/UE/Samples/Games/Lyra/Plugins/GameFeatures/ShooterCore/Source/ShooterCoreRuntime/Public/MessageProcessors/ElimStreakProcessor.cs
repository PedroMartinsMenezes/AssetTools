namespace AssetTool
{
    [JsonAsset("ElimStreakProcessor")]
    public class UElimStreakProcessor : UGameplayMessageProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}