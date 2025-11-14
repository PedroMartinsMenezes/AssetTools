namespace AssetTool
{
    [JsonAsset("BlackmagicCustomTimeStep")]
    public class UBlackmagicCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}