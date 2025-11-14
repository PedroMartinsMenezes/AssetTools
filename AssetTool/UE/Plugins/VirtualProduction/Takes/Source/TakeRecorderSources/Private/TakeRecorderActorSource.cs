namespace AssetTool
{
    [JsonAsset("TakeRecorderActorSource")]
    public class UTakeRecorderActorSource : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}