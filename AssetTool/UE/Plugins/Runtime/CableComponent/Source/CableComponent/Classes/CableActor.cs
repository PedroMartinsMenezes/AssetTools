namespace AssetTool
{
    [JsonAsset("CableActor")]
    public class ACableActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}