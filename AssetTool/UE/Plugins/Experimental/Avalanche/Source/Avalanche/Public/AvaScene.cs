namespace AssetTool
{
    [JsonAsset("AvaScene")]
    public class AAvaScene : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}