namespace AssetTool
{
    [JsonAsset("MassCharacterMovementToMassTranslator")]
    public class UMassCharacterMovementToMassTranslator : UMassTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCharacterMovementToActorTranslator")]
    public class UMassCharacterMovementToActorTranslator : UMassTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCharacterOrientationToMassTranslator")]
    public class UMassCharacterOrientationToMassTranslator : UMassTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCharacterOrientationToActorTranslator")]
    public class UMassCharacterOrientationToActorTranslator : UMassTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}