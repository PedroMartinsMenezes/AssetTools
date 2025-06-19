namespace AssetTool
{
    [JsonAsset("OptimusValueContainerGeneratorClass")]
    public class UOptimusValueContainerGeneratorClass : UClass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusValueContainer")]
    public class UOptimusValueContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}