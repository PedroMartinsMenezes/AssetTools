namespace AssetTool
{
    [JsonAsset("GroupActor")]
    public class AGroupActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}