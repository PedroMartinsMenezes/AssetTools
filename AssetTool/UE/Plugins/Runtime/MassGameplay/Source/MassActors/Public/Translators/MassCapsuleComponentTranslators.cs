namespace AssetTool
{
    [JsonAsset("MassCapsuleTransformToMassTranslator")]
    public class UMassCapsuleTransformToMassTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassTransformToActorCapsuleTranslator")]
    public class UMassTransformToActorCapsuleTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}