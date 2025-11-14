namespace AssetTool
{
    [JsonAsset("ActorFactoryMediaPlate")]
    public class UActorFactoryMediaPlate : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}