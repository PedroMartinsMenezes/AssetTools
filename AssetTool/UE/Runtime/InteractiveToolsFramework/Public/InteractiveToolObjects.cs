namespace AssetTool
{
    [JsonAsset("InternalToolFrameworkActor")]
    public class AInternalToolFrameworkActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}