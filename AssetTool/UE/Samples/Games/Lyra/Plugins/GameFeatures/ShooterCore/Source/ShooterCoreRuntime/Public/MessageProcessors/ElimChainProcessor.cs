namespace AssetTool
{
    [JsonAsset("ElimChainProcessor")]
    public class UElimChainProcessor : UGameplayMessageProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}