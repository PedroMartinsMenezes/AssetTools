namespace AssetTool
{
    [JsonAsset("NNEDenoiserAsset")]
    public class UNNEDenoiserAsset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}