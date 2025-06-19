namespace AssetTool
{
    [JsonAsset("AITask_MoveTo")]
    public class UAITask_MoveTo : UAITask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}