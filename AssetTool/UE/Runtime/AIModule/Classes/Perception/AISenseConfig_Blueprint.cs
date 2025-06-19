namespace AssetTool
{
    [JsonAsset("AISenseConfig_Blueprint")]
    public class UAISenseConfig_Blueprint : UAISenseConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}