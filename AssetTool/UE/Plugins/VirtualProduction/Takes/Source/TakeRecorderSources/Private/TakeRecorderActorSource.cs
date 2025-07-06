namespace AssetTool
{
    [JsonAsset("TakeRecorderActorSource")]
    public class UTakeRecorderActorSource : UTakeRecorderSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}