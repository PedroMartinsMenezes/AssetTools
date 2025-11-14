namespace AssetTool
{
    [JsonAsset("MassSceneComponentLocationToMassTranslator")]
    public class UMassSceneComponentLocationToMassTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassSceneComponentLocationToActorTranslator")]
    public class UMassSceneComponentLocationToActorTranslator : UMassTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}