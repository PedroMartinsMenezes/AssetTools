namespace AssetTool
{
    [JsonAsset("Note")]
    public class ANote : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}