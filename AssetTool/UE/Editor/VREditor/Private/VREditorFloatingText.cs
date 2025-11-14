namespace AssetTool
{
    [JsonAsset("FloatingText")]
    public class AFloatingText : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}