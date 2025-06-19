namespace AssetTool
{
    [JsonAsset("EnvQuery")]
    public class UEnvQuery : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}