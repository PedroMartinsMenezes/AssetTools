namespace AssetTool
{
    [JsonAsset("AmbientSound")]
    public class AAmbientSound : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}