namespace AssetTool
{
    [JsonAsset("Note")]
    public class ANote : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}