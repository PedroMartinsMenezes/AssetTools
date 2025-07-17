namespace AssetTool
{
    [JsonAsset("ElimChainProcessor")]
    public class UElimChainProcessor : UGameplayMessageProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}