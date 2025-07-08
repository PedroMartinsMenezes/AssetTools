namespace AssetTool
{
    [JsonAsset("BlackmagicCustomTimeStep")]
    public class UBlackmagicCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}