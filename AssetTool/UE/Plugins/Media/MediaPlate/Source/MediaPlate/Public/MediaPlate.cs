namespace AssetTool
{
    [JsonAsset("MediaPlate")]
    public class AMediaPlate : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}