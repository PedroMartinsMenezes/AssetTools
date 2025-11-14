namespace AssetTool
{
    [JsonAsset("AITask")]
    public class UAITask : UGameplayTask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}