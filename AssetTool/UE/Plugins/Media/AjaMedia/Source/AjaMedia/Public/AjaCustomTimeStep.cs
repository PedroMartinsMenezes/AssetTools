namespace AssetTool
{
    [JsonAsset("AjaCustomTimeStep")]
    public class UAjaCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}