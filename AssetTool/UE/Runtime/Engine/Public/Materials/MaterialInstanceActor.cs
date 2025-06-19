namespace AssetTool
{
    [JsonAsset("MaterialInstanceActor")]
    public class AMaterialInstanceActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}