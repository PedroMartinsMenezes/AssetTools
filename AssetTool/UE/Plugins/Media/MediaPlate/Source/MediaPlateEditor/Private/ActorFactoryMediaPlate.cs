namespace AssetTool
{
    [JsonAsset("ActorFactoryMediaPlate")]
    public class UActorFactoryMediaPlate : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}