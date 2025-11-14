namespace AssetTool
{
    [JsonAsset("MaterialInstanceActor")]
    public class AMaterialInstanceActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}