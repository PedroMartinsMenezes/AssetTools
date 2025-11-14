namespace AssetTool
{
    [JsonAsset("MassTranslator_BehaviorTree")]
    public class UMassTranslator_BehaviorTree : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}