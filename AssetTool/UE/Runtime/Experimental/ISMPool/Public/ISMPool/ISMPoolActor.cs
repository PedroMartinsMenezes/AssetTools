namespace AssetTool
{
    [JsonAsset("ISMPoolActor")]
    public class AISMPoolActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}