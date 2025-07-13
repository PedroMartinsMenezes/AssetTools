namespace AssetTool
{
    [JsonAsset("MassTranslator_BehaviorTree")]
    public class UMassTranslator_BehaviorTree : UMassTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}