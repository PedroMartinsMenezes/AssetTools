namespace AssetTool
{
    [JsonAsset("MediaPlate")]
    public class AMediaPlate : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}