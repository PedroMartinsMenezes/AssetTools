namespace AssetTool
{
    [JsonAsset("Note")]
    public class ANote : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}