namespace AssetTool
{
    [JsonAsset("MyAwesomeActor")]
    public class AMyAwesomeActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}