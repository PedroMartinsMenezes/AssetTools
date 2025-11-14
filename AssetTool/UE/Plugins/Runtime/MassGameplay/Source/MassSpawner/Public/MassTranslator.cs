namespace AssetTool
{
    [JsonAsset("MassTranslator")]
    public class UMassTranslator : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}