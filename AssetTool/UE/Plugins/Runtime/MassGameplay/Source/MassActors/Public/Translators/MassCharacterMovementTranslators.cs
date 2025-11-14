namespace AssetTool
{
    [JsonAsset("MassCharacterMovementToMassTranslator")]
    public class UMassCharacterMovementToMassTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCharacterMovementToActorTranslator")]
    public class UMassCharacterMovementToActorTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCharacterOrientationToMassTranslator")]
    public class UMassCharacterOrientationToMassTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCharacterOrientationToActorTranslator")]
    public class UMassCharacterOrientationToActorTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}