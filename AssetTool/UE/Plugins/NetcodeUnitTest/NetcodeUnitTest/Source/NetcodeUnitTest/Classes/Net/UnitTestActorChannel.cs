namespace AssetTool
{
    [JsonAsset("UnitTestActorChannel")]
    public class UUnitTestActorChannel : UActorChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}