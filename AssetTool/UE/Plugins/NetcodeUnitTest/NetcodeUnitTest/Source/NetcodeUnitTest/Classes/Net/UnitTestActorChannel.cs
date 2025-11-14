namespace AssetTool
{
    [JsonAsset("UnitTestActorChannel")]
    public class UUnitTestActorChannel : UActorChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}