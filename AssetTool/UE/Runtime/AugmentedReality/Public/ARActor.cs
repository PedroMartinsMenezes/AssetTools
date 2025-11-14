namespace AssetTool
{
    [JsonAsset("ARActor")]
    public class AARActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}