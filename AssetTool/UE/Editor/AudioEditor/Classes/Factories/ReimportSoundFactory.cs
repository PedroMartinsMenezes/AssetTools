namespace AssetTool
{
    [JsonAsset("ReimportSoundFactory")]
    public class UReimportSoundFactory : USoundFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}