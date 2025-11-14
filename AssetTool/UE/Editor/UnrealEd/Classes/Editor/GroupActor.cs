namespace AssetTool
{
    [JsonAsset("GroupActor")]
    public class AGroupActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}