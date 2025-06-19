namespace AssetTool
{
    [JsonAsset("DatasmithOptionsBase")]
    public class UDatasmithOptionsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithCommonTessellationOptions")]
    public class UDatasmithCommonTessellationOptions : UDatasmithOptionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithImportOptions")]
    public class UDatasmithImportOptions : UDatasmithOptionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}