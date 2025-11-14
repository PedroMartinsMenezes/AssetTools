namespace AssetTool
{
    [JsonAsset("AvaTextActor")]
    public class AAvaTextActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}