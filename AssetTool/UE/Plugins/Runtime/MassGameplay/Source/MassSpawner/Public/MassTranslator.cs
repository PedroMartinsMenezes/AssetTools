namespace AssetTool
{
    [JsonAsset("MassTranslator")]
    public class UMassTranslator : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}