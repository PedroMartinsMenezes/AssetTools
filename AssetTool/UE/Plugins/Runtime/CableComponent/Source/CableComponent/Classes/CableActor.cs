namespace AssetTool
{
    [JsonAsset("CableActor")]
    public class ACableActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}