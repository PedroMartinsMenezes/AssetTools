namespace AssetTool
{
    [JsonAsset("GroupActor")]
    public class AGroupActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}