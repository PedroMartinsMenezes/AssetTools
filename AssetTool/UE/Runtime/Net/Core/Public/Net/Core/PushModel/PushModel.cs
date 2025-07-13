namespace AssetTool
{
    [JsonAsset("MyAwesomeActor")]
    public class AMyAwesomeActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}