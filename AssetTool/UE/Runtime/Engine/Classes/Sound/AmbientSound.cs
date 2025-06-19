namespace AssetTool
{
    [JsonAsset("AmbientSound")]
    public class AAmbientSound : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}