namespace AssetTool
{
    [JsonAsset("LyraPawnData")]
    public class ULyraPawnData : UPrimaryDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}