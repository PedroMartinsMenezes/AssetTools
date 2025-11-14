namespace AssetTool
{
    [JsonAsset("AITask_MoveTo")]
    public class UAITask_MoveTo : UAITask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}