namespace AssetTool
{
    [JsonAsset("MetaSoundBaseFactory")]
    public class UMetaSoundBaseFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundFactory")]
    public class UMetaSoundFactory : UMetaSoundBaseFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundSourceFactory")]
    public class UMetaSoundSourceFactory : UMetaSoundBaseFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}