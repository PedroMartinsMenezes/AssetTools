namespace AssetTool
{
    [JsonAsset("ARActor")]
    public class AARActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}