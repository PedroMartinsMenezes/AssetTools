namespace AssetTool
{
    [JsonAsset("AjaCustomTimeStep")]
    public class UAjaCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}