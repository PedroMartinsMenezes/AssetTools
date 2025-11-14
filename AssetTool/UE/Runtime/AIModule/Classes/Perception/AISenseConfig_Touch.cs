namespace AssetTool
{
    [JsonAsset("AISenseConfig_Touch")]
    public class UAISenseConfig_Touch : UAISenseConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}